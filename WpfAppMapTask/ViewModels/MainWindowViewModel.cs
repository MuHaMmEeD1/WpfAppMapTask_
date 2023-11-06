using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WpfAppMapTask.Models;

namespace WpfAppMapTask.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        BBus? bBus;
      

        public BBus? BBuss { get => bBus; set { bBus = value; OnPropertyChinged(); } }
        public MainWindowViewModel()
        {


            BBuss = JsonSerializer.Deserialize<BBus>(File.ReadAllText("C:\\Users\\AzComp\\source\\repos\\WpfAppMapTask\\WpfAppMapTask\\DataBase\\BakuBus.json"));

            


        }

        










        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChinged([CallerMemberName] string? name = null)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }



    }
}
