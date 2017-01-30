using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMH_Desktop
{
    class Machine
    {
        private String code;
        private int type;
        private String year;
        private String phoneNumber;
        private String model;
        private String serialNumber;
        private String manager;
        private String electricConnection;
        private Boolean pneumaticConnection;
        private Boolean hidraulicSystem;
        private String dimmensions;
        private String powerSource;
        private String weight;
        private String typeOfOil;
        private String workingPressure;
        private int state;
        private String manufacturer;
        private String severity;
        private String fileSearch;
        private String workzoneId;

        public Machine() { }

        public Machine(String code, int type, String year, String phoneNumber, String model, String serialNumber, String manager, String electricConnection, Boolean pneumaticConnection, Boolean hidraulicSystem,
            String dimmensions, String powerSource, String weight, String typeOfOil, String workingPressure, int state, String manufacturer, String severity, String fileSearch, String workzoneId)
        {
            this.code = code;
            this.type = type;
            this.year = year;
            this.phoneNumber = phoneNumber;
            this.model = model;
            this.serialNumber = serialNumber;
            this.manager = manager;
            this.electricConnection = electricConnection;
            this.pneumaticConnection = pneumaticConnection;
            this.hidraulicSystem = hidraulicSystem;
            this.dimmensions = dimmensions;
            this.powerSource = powerSource;
            this.weight = weight;
            this.typeOfOil = typeOfOil;
            this.workingPressure = workingPressure;
            this.state = state;
            this.manufacturer = manufacturer;
            this.severity = severity;
            this.fileSearch = fileSearch;
            this.workzoneId = workzoneId;
        }

        public String Code
        {
            get { return code; }
            set { code = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public String Year
        {
            get { return year; }
            set { year = value; }
        }

        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public String SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        public String Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public String ElectricConnection
        {
            get { return electricConnection; }
            set { electricConnection = value; }
        }

        public Boolean PneumaticConnection
        {
            get { return pneumaticConnection; }
            set { pneumaticConnection = value; }
        }

        public Boolean HidraulicSystem
        {
            get { return hidraulicSystem; }
            set { hidraulicSystem = value; }
        }

        public String Dimmensions
        {
            get { return dimmensions; }
            set { dimmensions = value; }
        }

        public String PowerSource
        {
            get { return powerSource; }
            set { powerSource = value; }
        }

        public String Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public String TypeOfOil
        {
            get { return typeOfOil; }
            set { typeOfOil = value; }
        }

        public String WorkingPressure
        {
            get { return workingPressure; }
            set { workingPressure = value; }
        }

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public String Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public String Severity
        {
            get { return severity; }
            set { severity = value; }
        }

        public String FileSearch
        {
            get { return fileSearch; }
            set { fileSearch = value; }
        }

        public String WorkzoneId
        {
            get { return workzoneId; }
            set { workzoneId = value; }
        }
    }
}
