using BusinessAccessLayer;
using BusinessAccessLayer.Model;
using MotorDrivingSchool.Screens.Training;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorDrivingSchool.Controls
{
    public partial class ctrTrainingMotor : UserControl
    {

        private Timer _timer;
        private TimeSpan _timeSpan;

        private bool _hasStarted;

        private DateTime _startTime;



        clsTrainee _trainee;
        clsCourse _course;


        public ctrTrainingMotor()
        {
            InitializeComponent();
         
            this._hasStarted = false;            
            this._initializeTimerSettings();
            this._restLabelValues();
        }


        private void btnStart_Click_1(object sender, EventArgs e)
        {
         
            if (this._hasStarted == true)
            {
                this._timer.Start();
                return;
            }

            frmTrainingInfo form = new frmTrainingInfo();

            if (form.ShowDialog() != DialogResult.OK)
            {
                return;
            }


            this._hasStarted = true;


            string traineePhoneNumber = form.traineePhoneNumber;
            string durrationInHours = form.durration.ToString();
            float numberOfReservedHours = float.Parse(durrationInHours);

            this._course = clsCourse.findCourseByTraineePhoneNumber(traineePhoneNumber);
            this._course.mode = clsCourse.enMode.Update;
            this._trainee = clsTrainee.getTraineeByTraineeID(this._course.traineeID);

            this.lblName.Text = this._trainee.person.fullname.ToString();
           

            this._course.remainingHours = this._course.remainingHours - numberOfReservedHours;

            

            this._timeSpan = TimeSpan.FromHours(numberOfReservedHours);

            this._timer.Start();
            this._startTime = DateTime.Now;
        }

        private void btnPause_Click_1(object sender, EventArgs e)
        {
            this._timer.Stop();
        }

        private void btnEnd_Click_1(object sender, EventArgs e)
        {
            this._timer.Stop();

            if (this._course.save())
            {
                MessageBox.Show("Remaining Hours Updated Successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed To Update Remaining Hours", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._resetRoomSettings();
        }


        // Private methods

        private void _timerTick(object sender, EventArgs e)
        {
            if (this._timeSpan.Ticks <= 0)
            {
                this._timer.Stop();


                if (this._course.save())
                {
                    MessageBox.Show("Remaining Hours Updated Successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed To Update Remaining Hours", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                this._resetRoomSettings();

                return;
            }

            // Decrement One Second
            this._timeSpan = this._timeSpan.Subtract(TimeSpan.FromSeconds(1));

            lblRemainingTime.Text = this._timeSpan.ToString(@"hh\:mm\:ss");
        }
        private void _initializeTimerSettings()
        {
            this._timer = new Timer();
            this._timeSpan = TimeSpan.Zero;

            this._timer.Interval = 1000;
            this._timer.Tick += this._timerTick;
        }



        private void _restLabelValues()
        {
            this._restPlayerNameLabel();
            this._resetRemainingTimeLabel();
        }
        private void _restPlayerNameLabel()
        {
            this.lblName.Text = "";
        }
        private void _resetRemainingTimeLabel()
        {
            this.lblRemainingTime.Text = "";
        }
        private void _resetRoomSettings()
        {
            this._restLabelValues();
            this._hasStarted = false;
        }

  
    }
}
