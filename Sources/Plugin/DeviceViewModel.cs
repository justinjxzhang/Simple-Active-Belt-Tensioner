using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.ActiveBeltTensioner
{
    public class DeviceViewModel
    {
        private readonly DevicePlugin _pluginInstance;

        public DeviceSettings Settings { get; }
        public MotorController MotorController { get; }
        public PlotModel TelemetryGraphModel { get; }
        
        public bool IsEnabled {
            get => _pluginInstance.IsEnabled;
            set => _pluginInstance.IsEnabled = value;
        }

        public DeviceViewModel(
            DeviceSettings settings,
            MotorController motorController,
            PlotModel telemetryGraphModel,
            DevicePlugin pluginInstance
        )
        {
            _pluginInstance = pluginInstance;
            Settings = settings;
            MotorController = motorController;
            TelemetryGraphModel = telemetryGraphModel;
        }
    }
}
