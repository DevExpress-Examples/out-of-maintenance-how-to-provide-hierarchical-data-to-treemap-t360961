using DevExpress.XtraTreeMap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HierarchicalDataAdapterSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CreateTreeMapDataAdapter();
            CreateTreeMapColorizer();
        }

        #region #CreateDataAdapter
        void CreateTreeMapDataAdapter() {
            TreeMapHierarchicalDataAdapter dataAdapter = new TreeMapHierarchicalDataAdapter();
            dataAdapter.DataSource = CreateStatistics();
            
            // Fill the Mappings collection using mappings specifying 
            // how to convert data objects to tree map items.
            dataAdapter.Mappings.Add(new TreeMapHierarchicalDataMapping {
                Type = typeof(CountryStatistics),
                LabelDataMember = "Name",
                ChildrenDataMember = "EnergyStatistics"
            });
            dataAdapter.Mappings.Add(new TreeMapHierarchicalDataMapping {
                Type = typeof(EnergyInfo),
                LabelDataMember = "Type",
                ValueDataMember = "Value"
            });

            treeMap.DataAdapter = dataAdapter;
        }
        #endregion #CreateDataAdapter

        #region #GradientColorizer
        void CreateTreeMapColorizer() {
            treeMap.Colorizer = new TreeMapGradientColorizer {
                StartColor = Color.Black,
                EndColor = Color.White
            };
        }
        #endregion #GradientColorizer

        List<CountryStatistics> CreateStatistics() {
            List<CountryStatistics> statistics = new List<CountryStatistics>();
            XDocument doc = XDocument.Load("..\\..\\Data\\EnergyStatistic.xml");
            foreach(XElement xCountry in doc.Element("ArrayOfEnergyStatistic").Elements("CountryEnergyInfo")) {
                CountryStatistics countryStatistics = new CountryStatistics();
                countryStatistics.Name = xCountry.Attribute("Country").Value;
                foreach(XElement xEnergyInfo in xCountry.Elements("EnergyStatistic")) {
                    countryStatistics.EnergyStatistics.Add(new EnergyInfo {
                        Type = xEnergyInfo.Attribute("TypeName").Value,
                        Value = Convert.ToDouble(xEnergyInfo.Attribute("Value").Value)
                    });
                }
                statistics.Add(countryStatistics);
            }
            return statistics;
        }
    }
}
