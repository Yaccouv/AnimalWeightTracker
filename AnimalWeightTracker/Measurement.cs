using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace AnimalWeightTracker
{
    interface Measurement
    {
        int aAnimalID { get; set; }
        string Time { get; set; }
        DateTime adate { get; set; }

        void SetweightORwaist(string animalName, ComboBox cmbMeasuretype, string measure, ComboBox cmbTime, DateTime date);
        bool AddweightORwaist(string animalName, ComboBox cmbMeasuretype, string measure, ComboBox cmbTime, DateTime date);
        bool UpdateweightORwaist(string animalName, ComboBox cmbMeasuretype, string measure, ComboBox cmbTime);
        bool DeleteweightORwaist();
        DataTable ReadMeasurement(string animalname);
    }
}
