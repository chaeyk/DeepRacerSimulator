using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepRacer
{
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
        }

        public static Setting OpenDialog(Setting currentSetting)
        {
            var form = new FrmSetting();
            form.ApplySetting(currentSetting);
            if (form.ShowDialog() == DialogResult.OK)
            {
                return form.GetSetting();
            }
            else
            {
                return null;
            }
        }

        public void ApplySetting(Setting setting)
        {
            tbMaxSteer.Text = setting.MaxSteer.ToString();
            cbSteerSteps.SelectedItem = setting.SteerSteps.ToString();
            tbMaxSpeed.Text = setting.MaxSpeed.ToString();
            cbSpeedSteps.SelectedItem = setting.SpeedSteps.ToString();
        }

        public Setting GetSetting()
        {
            return new Setting()
            {
                MaxSteer = int.Parse(tbMaxSteer.Text),
                SteerSteps = int.Parse(cbSteerSteps.SelectedItem.ToString()),
                MaxSpeed = int.Parse(tbMaxSpeed.Text),
                SpeedSteps = int.Parse(cbSpeedSteps.SelectedItem.ToString()),
            };
        }
    }
}
