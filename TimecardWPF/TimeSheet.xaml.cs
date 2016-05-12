using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TimecardWPF
{
    /// <summary>
    /// Interaction logic for TimeSheet.xaml
    /// </summary>
    public partial class TimeSheet : UserControl
    {
        public DateTime ChargeDate { get; set; }
        public Project Project { get; set; }
        public Objective Objective { get; set; }

        public TimeSheet()
        {
            InitializeComponent();
        }
    }

    public class Objective {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() {
            return $"{Id} - {Name}";
        }
    }

    public class Project {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
