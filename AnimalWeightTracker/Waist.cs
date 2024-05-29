using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWeightTracker
{
    class Waist : Measurement
    {
        DatabaseConnection database = new DatabaseConnection();
        Animal animal = new Animal();



        public int MeasurementID
        {
            get;
            set;
        }
        public double aMeasure
        {
            get;
            set;
        }


        public int aAnimalID
        {
            get;
            set;
        }
        public string Time
        {
            get;
            set;
        }
        public string aType
        {
            get;
            set;
        }

        public DateTime adate
        {
            get;
            set;
        }
        public DateTime date
        {
            get;
            set;
        }


        public void SetweightORwaist(string animalName, ComboBox cmbMeasuretype, string measure, ComboBox cmbTime, DateTime date)
        {
            aAnimalID = animal.retrieveAnimalID(animalName);
            Time = cmbTime.Text;
            aMeasure = Convert.ToDouble(measure);
            aType = cmbMeasuretype.Text;
            adate = date.Date;
        }

        public bool AddweightORwaist(string animalName, ComboBox cmbMeasuretype, string measure, ComboBox cmbTime, DateTime date)
        {
            SetweightORwaist(animalName, cmbMeasuretype, measure, cmbTime, date);
        
            string query = "insert into Measurement Values('" + aMeasure + "','" + aType + "','" + aAnimalID + "','" + Time + "','" + date + "')";
            database.Manipulate(query);
            MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            return true;
        }

        public bool UpdateweightORwaist(string animalName, ComboBox cmbMeasuretype, string measure, ComboBox cmbTime)
        {
            SetweightORwaist(animalName, cmbMeasuretype, measure, cmbTime, date);
            string query = "update Measurement set Time='" + Time + "', AnimalID='" + aAnimalID + "', Measurement='" + aMeasure + "', MeasurementType='" + aType + "' where MeasurementID='" + MeasurementID + "'";
            database.Manipulate(query);
            MessageBox.Show("Record Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            return true;
        }

        public bool DeleteweightORwaist()
        {
            string query = "delete from AnimalonExercise where MeasurementID='" + MeasurementID + "'";
            database.Manipulate(query);
            MessageBox.Show("Record Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            return true;
        }

        public DataTable ReadMeasurement(string animalname)
        {
            aAnimalID = animal.retrieveAnimalID(animalname);
            string type = "Waist";
            var dt = new DataTable();
            using (var cn = database.Con)
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = " select * from Measurement where AnimalID='" + aAnimalID + "' and MeasurementType='"+type+"'";
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                }

            }
            return dt;
        }

        public void AverageWaist(string animalname, string date)
        {
            Label average = Application.OpenForms["ManageAnimals"].Controls["tabControl1"].Controls["tabPage4"].Controls["lblWaist"] as Label;
            string type = "Waist";
            double morning = 0;
            double evening = 0;
            string time1 = "Morning";
            string time2 = "Evening";

            aAnimalID = animal.retrieveAnimalID(animalname);
            string query = "select * from Measurement where AnimalID ='" + aAnimalID + "'and Date='" + date + "' and MeasurementType='" + type + "' and Time='" + time1 + "'";
            DataSet ds = database.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    morning = double.Parse(dr.ItemArray.GetValue(1).ToString());
                }
            }

            string query1 = "select * from Measurement where AnimalID ='" + aAnimalID + "'and Date='" + date + "' and MeasurementType='" + type + "' and Time='" + time2 + "'";
            DataSet ds1 = database.select(query1);
            if (ds1.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr1 in ds1.Tables[0].Rows)
                {
                    evening = double.Parse(dr1.ItemArray.GetValue(1).ToString());
                }
            }
            average.Text = ((Convert.ToDouble(morning) + Convert.ToDouble(evening)) / 2).ToString();

        }
    }
}
