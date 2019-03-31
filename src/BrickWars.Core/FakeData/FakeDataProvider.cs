using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrickWars.Core.Models;
using MvvmCross.ViewModels;

namespace BrickWars.Core.FakeData
{
    public static class FakeDataProvider
    {
        public static List<EquipmentModel> FakeEquipments { get; }
        public static List<WarriorModel> FakeWarriors { get; }
        public static List<ArmyModel> FakeArmyModels { get; }

        static FakeDataProvider()
        {
            FakeEquipments = new List<EquipmentModel>
            {
                new EquipmentModel
                {
                    Id = Guid.NewGuid(),
                    Image = "https://www.lapetitebrique.com/10830-thickbox_default/lego-custom-accessories-star-wars-helmets-clone-army-customs-clone-phase-2-bomb-squad-helmet.jpg",
                    Type = EquipmentType.Armor,
                    Points = 10,
                    IsBroken = false
                },
                new EquipmentModel
                {
                    Id = Guid.NewGuid(),
                    Image = "https://images3.sw-cdn.net/product/picture/710x528_16277493_9246604_1477781002.jpg",
                    Type = EquipmentType.Armor,
                    Points = 15,
                    IsBroken = true
                },
                new EquipmentModel
                {
                    Id = Guid.NewGuid(),
                    Image = "https://img.wonderhowto.com/img/21/86/63427896924228/0/160-piece-arsenal-life-sized-lego-weapons.w1456.jpg",
                    Type = EquipmentType.Gun,
                    Points = 100,
                    IsBroken = false
                },
                new EquipmentModel
                {
                    Id = Guid.NewGuid(),
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_cunwA1GZ7fB6pjGcuUYe9InIbS4xfDi578VJJra3fc3nAWJ8",
                    Type = EquipmentType.Gun,
                    Points = 65,
                    IsBroken = true
                },
                new EquipmentModel
                {
                    Id = Guid.NewGuid(),
                    Image = "https://www.brickwarriors.com/product_images/uploaded_images/40252094230-08298f7123-b.jpg",
                    Type = EquipmentType.Gun,
                    Points = 35,
                    IsBroken = false
                }
            };

            FakeWarriors = new List<WarriorModel>
            {
                new WarriorModel
                {
                    Id = Guid.NewGuid(),
                    Image = "https://m.media-amazon.com/images/I/71IMqgVJGwL._SR500,500_.jpg",
                    Points = 250,
                    Type = WarriorType.Soldier,
                    IsAlive = true,
                    Equipments = new MvxObservableCollection<EquipmentModel>(FakeEquipments)
                },
                new WarriorModel
                {
                    Id = Guid.NewGuid(),
                    Image = "https://m.media-amazon.com/images/I/61SBtS%20bKXL._SR500,500_.jpg",
                    Points = 200,
                    Type = WarriorType.Soldier,
                    IsAlive = false,
                    Equipments = new MvxObservableCollection<EquipmentModel>(FakeEquipments)
                },
                new WarriorModel
                {
                    Id = Guid.NewGuid(),
                    Image = "https://c.76.my/Malaysia/lego-teenage-mutant-ninja-turtle-foot-soldier-full-face-minifigure-yesbrick-1409-29-yesbrick@12.jpg",
                    Points = 150,
                    Type = WarriorType.Soldier,
                    IsAlive = true,
                    Equipments = new MvxObservableCollection<EquipmentModel>(FakeEquipments)
                },
                new WarriorModel
                {
                    Id = Guid.NewGuid(),
                    Image = "https://cdn.shopify.com/s/files/1/2652/5464/products/lego-m1128-tank-1678-pieces_580x.jpg?v=1542252260",
                    Points = 1500,
                    Type = WarriorType.Tank,
                    IsAlive = false,
                    Equipments = new MvxObservableCollection<EquipmentModel>()
                },
                new WarriorModel
                {
                    Id = Guid.NewGuid(),
                    Image = "http://i.ebayimg.com/00/s/NTAwWDUwMA==/z/IgMAAOxyYSdS-zIa/$_3.JPG?set_id=2",
                    Points = 900,
                    Type = WarriorType.Vehicle,
                    IsAlive = true,
                    Equipments = new MvxObservableCollection<EquipmentModel>()
                },
                new WarriorModel
                {
                    Id = Guid.NewGuid(),
                    Image = "https://i.ebayimg.com/00/s/NDQ0WDUwMA==/z/hCQAAMXQVERSsR8G/$_35.JPG",
                    Points = 450,
                    Type = WarriorType.Vehicle,
                    IsAlive = true,
                    Equipments = new MvxObservableCollection<EquipmentModel>()
                },
                new WarriorModel
                {
                    Id = Guid.NewGuid(),
                    Image = "https://i.ytimg.com/vi/jOLgkXIWU84/maxresdefault.jpg",
                    Points = 750,
                    Type = WarriorType.Vehicle,
                    IsAlive = true,
                    Equipments = new MvxObservableCollection<EquipmentModel>()
                }
            };

            FakeArmyModels = new List<ArmyModel>();

            var army = new ArmyModel
            {
                Id = Guid.NewGuid(),
                Image = "https://cdn.shopify.com/s/files/1/2652/5464/products/lego-army-headquarters-1086-pieces_580x.jpg",
                Points = 3250,
                Name = "Full Army"
            };
            army.Warriors.AddRange(FakeWarriors);
            FakeArmyModels.Add(army);

            army = new ArmyModel
            {
                Id = Guid.NewGuid(),
                Image = "https://4.imimg.com/data4/VM/MA/MY-1132707/lego-army-toy-500x500.jpg",
                Points = 2500,
                Name = "Chaplain Corps"
            };
            army.Warriors.AddRange(FakeWarriors
                        .Where(w => w.Type != WarriorType.Tank));
            FakeArmyModels.Add(army);

            army = new ArmyModel
            {
                Id = Guid.NewGuid(),
                Image = "http://i.imgur.com/qEdYuFM.jpg",
                Points = 1500,
                Name = "Armor Branch"
            };
            army.Warriors.AddRange(FakeWarriors
                        .Where(w => w.Type == WarriorType.Tank));
            FakeArmyModels.Add(army);

            army = new ArmyModel
            {
                Id = Guid.NewGuid(),
                Image = "https://ae01.alicdn.com/kf/HTB1en_RXsfrK1RkSnb4q6xHRFXa5/6-sztuk-si-y-zbrojne-Army-MILITARY-SWAT-Uszczelki-Kamufla-o-nierze-Marine-Corps-Cegie-ki.jpg_640x640.jpg",
                Points = 1250,
                Name = "Air Defense Artillery"
            };
            army.Warriors.AddRange(FakeWarriors.Take(2));
            FakeArmyModels.Add(army);

            army = new ArmyModel
            {
                Id = Guid.NewGuid(),
                Image = "https://static.artfire.com/uploads/mfs/items/b8/aa/large/b8aaa7d01950718363a684e461ca902cbebf41723fa1d3a79338cc92ab413843.jpg",
                Points = 2700,
                Name = "Chemical Corps"
            };
            army.Warriors.AddRange(FakeWarriors.Take(4));
            FakeArmyModels.Add(army);
        }
    }
}
