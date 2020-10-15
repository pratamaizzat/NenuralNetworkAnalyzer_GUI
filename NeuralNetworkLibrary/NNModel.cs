using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuralNetworkLibrary
{
    public class NNModel
    {
        #region 1 hidden layer

        public int InputNodes { get; set; }
        public int HiddenNodes { get; set; }
        public int OutputNodes { get; set; }

        public MatrixModel WeightIH { get; set; }
        public MatrixModel WeightHO { get; set; }
        public MatrixModel BiasH { get; set; }
        public MatrixModel BiasO { get; set; }

        public double LearningRate { get; set; }

        public NNModel(int inputNodes, int hiddenNodes, int outputNodes)
        {
            InputNodes = inputNodes;
            HiddenNodes = hiddenNodes;
            OutputNodes = outputNodes;

            WeightIH = new MatrixModel(HiddenNodes, InputNodes);
            WeightHO = new MatrixModel(OutputNodes, HiddenNodes);
            WeightIH.Randomize();
            WeightHO.Randomize();

            BiasH = new MatrixModel(HiddenNodes, 1);
            BiasO = new MatrixModel(OutputNodes, 1);
            BiasH.Randomize();
            BiasO.Randomize();

            LearningRate = 0.05;
        }

        public double[] FeedForward(double[] input_array)
        {
            var inputs = MatrixModel.FromArray(input_array);
            var hidden = MatrixModel.MultiplyWithMatrix(WeightIH, inputs);
            hidden.AddWithMatrix(BiasH);
            // activation function!
            hidden.Map(Sigmoid);

            // Generating the output's output!
            var output = MatrixModel.MultiplyWithMatrix(WeightHO, hidden);
            output.AddWithMatrix(BiasO);
            output.Map(Sigmoid);

            return output.ToArray();
        }

        public double Train(double[] input_array, double[] target_array)
        {
            /// Generating the Hidden Outputs
            var inputs = MatrixModel.FromArray(input_array);
            var hidden = MatrixModel.MultiplyWithMatrix(WeightIH, inputs);
            hidden.AddWithMatrix(BiasH);
            // activation function!
            hidden.Map(Sigmoid);

            // Generating the output's output!
            var output = MatrixModel.MultiplyWithMatrix(WeightHO, hidden);
            output.AddWithMatrix(BiasO);
            output.Map(Sigmoid);

            var targets = MatrixModel.FromArray(target_array);

            //calculation total error
            var outputError = MatrixModel.SubtractMSE(targets, output);
            var errors = outputError.ToArray();
            double errTotal = 0;

            for(int i = 0; i < errors.Length; i++)
            {
                errTotal += errors[i];
            }
            //const reducer = (accumulator, currentValue) => accumulator + currentValue;
            //let errorTotal = errors.reduce(reducer);

            //calculation partial derivative respect output (output error)
            var output_errors = MatrixModel.Subtract(targets, output);
            output_errors.Multiply(-1);

            //calculation gradient
            var gradient = MatrixModel.Map(output, DSigmoid);
            gradient.MultiplyWithMatrix(output_errors);
            gradient.Multiply(LearningRate);

            //calculation deltas
            var hidden_T = MatrixModel.Transpose(hidden);
            var weight_ho_deltas = MatrixModel.MultiplyWithMatrix(gradient, hidden_T);

            //calculation partial derivative respect hidden (hidden error)
            var ho_t = MatrixModel.Transpose(WeightHO);
            var h_err = MatrixModel.Map(output, DSigmoid);
            h_err.MultiplyWithMatrix(output_errors);
            var hidden_errors = MatrixModel.MultiplyWithMatrix(ho_t, h_err);

            // calculate hidden gradient
            var hidden_gradient = MatrixModel.Map(hidden, DSigmoid);
            hidden_gradient.MultiplyWithMatrix(hidden_errors);
            hidden_gradient.Multiply(LearningRate);

            // calculate input->hidden deltas
            var input_T = MatrixModel.Transpose(inputs);
            var weight_ih_deltas = MatrixModel.MultiplyWithMatrix(hidden_gradient, input_T);

            // adjust weight by it deltas
            weight_ho_deltas.Multiply(-1);
            WeightHO.AddWithMatrix(weight_ho_deltas);
            // this.weights_ho.print();

            weight_ih_deltas.Multiply(-1);
            WeightIH.AddWithMatrix(weight_ih_deltas);
            // this.weights_ih.print();

            return errTotal;
        }

        #endregion

        #region Activation Function
        public double Sigmoid(double x)
        {
            return 1 / (1 + (Math.Exp(-x)));
        }

        public double DSigmoid(double y)
        {
            return y * (1 - y);
        }
        #endregion
    }
}
