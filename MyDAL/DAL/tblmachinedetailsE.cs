﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL.DAL
{
    //class tblmachinedetailsE
    //{
    //}

    public partial class tblmachinedetailsE
    {
        public int MachineID { get; set; }
        public string InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> PlantID { get; set; }
        public Nullable<int> ShopID { get; set; }
        public Nullable<int> CellID { get; set; }
        public string MachineName { get; set; }
        public string MachineDescription { get; set; }
        public string MachineDisplayName { get; set; }
        public Nullable<int> CellOrderNo { get; set; }
        public string IPAddress { get; set; }
        public Nullable<int> MachineType { get; set; }
        public string ControllerType { get; set; }
        public string MachineModel { get; set; }
        public string MachineMake { get; set; }
        public string ModelType { get; set; }
        public Nullable<int> IsParameters { get; set; }
        public string ShopNo { get; set; }
        public Nullable<int> IsPCB { get; set; }
        public Nullable<int> IsLevel { get; set; }
        public Nullable<int> IsNormalWC { get; set; }
        public Nullable<int> ManualWCID { get; set; }
        public Nullable<int> NoOfAxis { get; set; }
        public string MacType { get; set; }
        public Nullable<int> CurrentControlAxis { get; set; }
        public string ProgramNum { get; set; }
        public string ProgDBit { get; set; }
        public int MachineModelType { get; set; }
        public string MacConnName { get; set; }
        public string SpindleAxis { get; set; }
        public string TabIPAddress { get; set; }
        public Nullable<int> MachineLockBit { get; set; }
        public Nullable<int> MachineSetupBit { get; set; }
        public Nullable<int> MachineMaintBit { get; set; }
        public Nullable<int> MachineToolLifeBit { get; set; }
        public Nullable<int> MachineUnlockBit { get; set; }
        public Nullable<int> MachineIdleBit { get; set; }
        public Nullable<int> MachineIdleMin { get; set; }
        public int EnableLockLogic { get; set; }
        public int ServerTabFlagSync { get; set; }
        public int ServerTabCheck { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<bool> EnableToolLife { get; set; }
        public Nullable<int> IsBottelNeck { get; set; }
        public Nullable<int> IsFirstMachine { get; set; }
        public Nullable<int> IsLastMachine { get; set; }
        public Nullable<int> OperationNumber { get; set; }
        public int IsShiftWise { get; set; }
        public Nullable<int> LossFlag { get; set; }
        public Nullable<int> TransmissionFrequency { get; set; }
        public string LoggerType { get; set; }
        public Nullable<int> MachinePort { get; set; }
        public Nullable<int> NumOfAxis { get; set; }
        public Nullable<int> ToolGroupNum { get; set; }
        public Nullable<int> NumberOfCurrent { get; set; }
        public Nullable<int> NumberOfTemperature { get; set; }
        public Nullable<int> NumberOfPresure { get; set; }
        public Nullable<int> NumberOfLevel { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<bool> IsWimerasys { get; set; }
        public string IOTGatewayIP { get; set; }
        public Nullable<int> NodeID { get; set; }
        public int IsDLVersion { get; set; }
        public Nullable<int> machinePockets { get; set; }
        public Nullable<int> noOfPartsPerCycle { get; set; }
        public string Category { get; set; }
        public Nullable<int> MachineCategoryId { get; set; }
        public string MMMGroup { get; set; }
        public string dedicatedOrShared { get; set; }
        public string primaryOrSecondary { get; set; }
        public string machineSpec { get; set; }
        public Nullable<int> chuckOrRodSize { get; set; }
        public Nullable<int> noOfToolStation { get; set; }
        public Nullable<int> tallStockAvailId { get; set; }
        public Nullable<int> noOfAxisId { get; set; }
        public string tableSize { get; set; }
        public Nullable<int> palletId { get; set; }
    }



}
