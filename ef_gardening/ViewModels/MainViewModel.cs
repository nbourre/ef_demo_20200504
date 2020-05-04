using ef_gardening.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ef_gardening.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        GardeningContext db = new GardeningContext();

        public ObservableCollection<Plant> Plants { get; set; }
        public ObservableCollection<Region> Regions { get; set; }
        public ObservableCollection<Family> Families { get; set; }

        private Plant selectedPlant;

        public Plant SelectedPlant
        {
            get { return selectedPlant; }
            set { 
                selectedPlant = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            initValues();
        }

        private void initValues()
        {
            seedData();

            Plants = new ObservableCollection<Plant>(db.Plants);
            Regions = new ObservableCollection<Region>(db.Regions);
            Families = new ObservableCollection<Family>(db.Families);
        }

        void seedData()
        {
            db.Regions.Add(new Region() { Name = "Désertique" });
            db.Regions.Add(new Region() { Name = "Aride" });
            db.Regions.Add(new Region() { Name = "Tempéré" });

            db.SaveChanges();

            var desert = db.Regions.Where(r => r.Name == "Désertique").First();
            var aride = db.Regions.Where(r => r.Name == "Aride").First();
            var tempere = db.Regions.Where(r => r.Name == "Tempéré").First();

            db.Families.Add(new Family() { Name = "Graminé" });
            db.Families.Add(new Family() { Name = "Orchidé" });
            db.Families.Add(new Family() { Name = "Labié" });

            db.SaveChanges();

            var gram = db.Families.Where(f => f.Name == "Graminé").First();
            var orchid = db.Families.Where(f => f.Name == "Orchidé").First();
            var labie = db.Families.Where(f => f.Name == "Labié").First();

            db.Plants.Add(new Plant() { Height = 20, CommonName = "Pissenlit", Family = gram, Region = tempere });
            db.Plants.Add(new Plant() { Height = 20, CommonName = "Blé", Family = gram, Region = aride });
            db.Plants.Add(new Plant() { Height = 20, CommonName = "Orchid", Family = orchid, Region = desert });

            db.SaveChanges();

            Debug.WriteLine($"Regions : {db.Regions.Count()}");
        }

    }
}
