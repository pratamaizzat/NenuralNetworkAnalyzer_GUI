using NeuralNetworkLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork_2._0
{
    public partial class Dashboard : Form
    {
        private double[] value;
        public string JSONFile;
        public dynamic JsonModel;
        public JSONAttributes JAttributes = new JSONAttributes();
        public NNModel nn;
        public Dashboard()
        {
            InitializeComponent();
        }

        #region UI events
        private void LoadRawButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "JSON Files (*JSON; *json) | *JSON; *json;";

                if(file.ShowDialog() == DialogResult.OK)
                {
                    JSONFile = file.FileName;
                    ReadJson();

                    for (int i = 0; i < JsonModel["TrainData"].Count; i++)
                    {
                        value = new double[JsonModel["TrainData"][i]["inputs"].Count];

                        for (int j = 0; j < JsonModel["TrainData"][i]["inputs"].Count; j++)
                        {
                            value[j] = JsonModel["TrainData"][i]["inputs"][j].ToObject<double>();
                        }

                        JAttributes.Inputs.Add(value);
                    }

                    for (int i = 0; i < JsonModel["TrainData"].Count; i++)
                    {
                        value = new double[JsonModel["TrainData"][i]["targets"].Count];

                        for (int j = 0; j < JsonModel["TrainData"][i]["targets"].Count; j++)
                        {
                            value[j] = JsonModel["TrainData"][i]["targets"][j].ToObject<double>();
                        }

                        JAttributes.Targets.Add(value);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    double.TryParse(Input1Value.Text, out double in1);
                    double.TryParse(Input2Value.Text, out double in2);

                    double.TryParse(Target1Value.Text, out double tr1);
                    double.TryParse(Target2Value.Text, out double tr2);

                    int.TryParse(EpochValue.Text, out int epoch);
                    int.TryParse(HiddenPValue.Text, out int hidden);

                    double[] input = { in1, in2 };
                    double[] target = { tr1, tr2 };

                    double[] errorTotal = new double[epoch];

                    nn = new NNModel(input.Length, hidden, target.Length);

                    for(int i = 0; i < epoch; i++)
                    {
                        errorTotal[i] = nn.Train(input, target);
                    }

                    double[] result = nn.FeedForward(input);

                    Output1Value.Text = result[0].ToString();
                    Output2Value.Text = result[1].ToString();

                    ErrorTotalChart.Series[0].Points.Clear();
                    ShowErrorTotal(errorTotal);
                } 
                else
                {
                    MessageBox.Show("The Entire Fields Must Be Filled and Correct!", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region JSON Function
        private void ReadJson()
        {
            using (StreamReader r = new StreamReader(JSONFile))
            {
                string json = r.ReadToEnd();
                JsonModel = new JSONModel();
                JsonModel = JsonConvert.DeserializeObject<dynamic>(json);
            }
        }
        #endregion

        #region validation function
        private bool Validation()
        {
            bool output = true;

            bool in1 = double.TryParse(Input1Value.Text, out double inVal1);
            bool in2 = double.TryParse(Input2Value.Text, out double inVal2);

            bool tr1 = double.TryParse(Target1Value.Text, out double trVal1);
            bool tr2 = double.TryParse(Target2Value.Text, out double trVal2);

            bool epoch = int.TryParse(EpochValue.Text, out int epochVal);
            bool hiddenp = int.TryParse(HiddenPValue.Text, out int hiddenV);

            if (!in1) output = false;
            if (!in2) output = false;
            if (!tr1) output = false;
            if (!tr2) output = false;

            if (!epoch) output = false;
            if (epochVal < 0) output = false;
            if (!hiddenp) output = false;
            if (hiddenV < 0) output = false;

            if (JAttributes.Inputs.Count < 1) output = false;

            return output;
        }
        #endregion

        #region show Chart
        private void ShowErrorTotal(double[] err)
        {
            for(int i = 0; i < err.Length; i++)
            {
                ErrorTotalChart.Series[0].Points.AddXY(i, err[i]);
            }

            ErrorTotalChart.ChartAreas[0].AxisX.Minimum = 0;
            ErrorTotalChart.ChartAreas[0].AxisX.Maximum = err.Length;
        }
        #endregion
    }
}
