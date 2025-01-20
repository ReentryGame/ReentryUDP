using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReentryUDP.DomainModels
{
    public class DataPacket
    {
        public enum Craft { Mercury, Gemini, CommandModule, LunarModule, SpaceShuttle, Vostok }
        public Craft TargetCraft = Craft.Mercury;
        public enum MessageTypes { SetSwitch, PushButton }
        public MessageTypes MessageType = MessageTypes.SetSwitch;
        public int ID;
        public int ToPos;
    }


    public enum MercurySwitchID
    {
        NULL, CabinLight, PhotoLight, LaunchControl, StbyBtry, IsolBtry, Ammeter,
        AudioBus, FansACBus, CabinFan, SuitFan, ASCSAC, ASCSMode, ASCSAuto, ASCSGyro,
        ArmSquib, RetroDelay, RetroAtt, AutoRetroJett, RetractScope, AttitudeSelect,
        WarningLightsBrightness, VOXSwitch, Beacon, Transmit, UHFSelect, UHFDF,
        TLMLoFreq, LandingBag, RescueAids, AudioCabinPress, AudioO2Emer, AudioFuelQuan,
        AudioRetroWarn, LightsTest, AudioH2OCabin, AudioH2OSuit, AudioRetroReset,
        InletValve, Maneuver, Battery1, Battery2, Battery3, Standby1, Standby2, IsolatedBattery
    };

    public enum MercuryFuseID
    {
        NULL, SuitFan, InvrContrl, RetroJett, RetroMan, ProGramr, BloodPress,
        AntSwitch, ComvRcvrA, TrimHiFreq, EmerReserveDeploy, EmerLandBag, EmerRescueAids,
        PeriScope, ASCSDot05G, EmerDot05G, EmerDrogueDeploy, EmerMainDeploy, ReserveDeploy,
        AuxBcn, No1RetroRckt, No2RetroRckt, No3RetroRckt, EmerRetroSeq, EmerRetroJett,
        PhaseShifter, EmerCapSepCntrl, EmerEscapeRckt, TowerSepContrl, EmerTowerSep,
        EmerTowerJett, EmerPosgrd
    };
    public enum MercurySelectorID
    {
        NULL, DCSelector, ACSelector, RetroTimeModifier, CabinTemp, SuitTemp, InverterTemp,
        EPIInclination, LowerWindowShield, LeftWindowShield, RightWindowShield
    };
    public enum MercuryHandleID
    {
        NULL, Decompress, Repressurize, ManualControl, RollLock, PitchLock, YawLock,
        RingJettTower, RingSepCapsule, RingOpenSnorkelNow, RingDeployMainNow,
        RingDeployReserveNow, EmerO2, RetractPeriscope, PressRegHandle
    }; 
    public enum MercuryButtonID { NULL, RetroSeq, FireRetroNow, JettRetroNow, Dot05GNow, DeployDrogueNow, TimeZero }

    public enum GeminiSwitchID
    {
        NULL, FUSECoaxCntl,
        SquibBoostInsert, SquibRetroPWR, SquibRetroJett, SquibLanding, SquibRetro1, SquibRetro2, SquibRetro3, SquibRetro4,
        MainBattery1, MainBattery2, MainBattery3, MainBattery4, SquibBattery1, SquibBattery2, SquibBattery3,
        LightsBrightness, LightsTest,
        FuelCell1PurgeO2, FuelCell1PWR, FuelCell2PurgeO2, FuelCell2PWR, FuelCell1A, FuelCell1B, FuelCell1C, FuelCell2A, FuelCell2B, FuelCell2C,
        BusTie1, BusTie2,
        ControllerPWROAMS, ControllerPWRRCSA, ControllerPWRRCSB, ACPowerSource,
        MDIUPower, AuxTapePWR, ComputerPower, HorizonScannerSelect, HorizonScannerHeater,
        SuitFan, FUSESuitFan1, FUSESuitFan2, O2HighRate, CoolPriPumpA, CoolPriPumpB, CoolSecPumpA, CoolSecPumpB,
        RadiatorFlow, EvaporatorHeat, EvaporatprMaxFlow, EventTimerStart, EventTimerDirection, ElapsedTimeStarter,
        H2VacTank, CryoHeaterO2, CryoHeaterH2, OAMReg, PropMotoOAMS, PropMotRCSA, PropMotRCSB, FUSEDCDCConv,
        LightsCabin, LightsFDI, CTRLights,
        FUSEAudioAndUHFTR1, FUSEAudioAndUHFTR2, FUSEUHFRelay, FUSEToneVox, FUSETV, FUSEHFTR, FUSEAntCntl, FUSEWhipAntHF, FUSEWhipAntUHF, FUSEWhipAntDiplex,
        FUSEElectTimer, FUSEEventTimer, FUSEBoostCutoff1, FUSEBoostCutoff2, FUSERetroAuto, FUSERetroMan, FUSETr256, FUSEECSIndLts, FUSEIndLtTest, FUSESeqLightsPWR, FUSESeqLightsCntl, FUSEParaCntl,
        FUSEAttIncCntlRetro, FUSEAttIndCntlLdg, FUSEBoostInsertCntl1, FUSEBoostInsertCntl2, FUSERetroSeqCntl1, FUSERetroSeqCntl2, FUSELandingSecCntl1, FUSELandingSecCntl2, FDI1Controller, GuidanceSwitch,
        FUSEBeaconsC, FUSEBeaconsResc, FUSEBeaconsAcq, FUSEAUXRecp, FUSECryQty, FUSECoolPumpSecB, FUSECoolPumpSecA, FUSECoolPumpPriB, FUSECoolPumpPriA,
        FUSETMAC, FUSEXmtrsDT, FUSEXmtrsRT, FUSEXmtrsStbyPWR, FUSEXmtrsStbyCntl, FUSEPriO2Htrs, FUSEH2OHtrs, FUSEClkLt,
        FUSEOAMSHtrs, FUSEEvapThr, FUSECoolVlvsSec, FUSECoolVlvsPri, FUSEO2RateCntl,
        ACMEBiasPWR, RollJetsSelector, FUSEACMECntl1, FUSEACMECntl2, FUSEOAMSCntlProp, FUSEOAMSCntlReg1, FUSEOAMSCntlReg2, FUSERCSSquibs1, FUSERCSSquibs2,
        OAMSResvSwitch, FUSEManThru9, FUSEManThru10, FUSEManThru11, FUSEManThru12, FUSEManThru13, FUSEManThru14, FUSEManThru15, FUSEManThru16,
        AttitiudeDriversSwitch, FUSEAttThrust1, FUSEAttThrust2, FUSEAttThrust3, FUSEAttThrust4, FUSEAttThrust5, FUSEAttThrust6, FUSEAttThrust7, FUSEAttThrust8,
        ACMELogicYawSelector, ACMELogicPitchSelector, ACMELogicRollSelector, FUSERCSAPitch, FUSERCSAYawL, FUSERCSAYawR, FUSERCSBPitch, FUSERCSBYawL, FUSERCSBYawR,
        FUSEAUXTape, FUSESEOInst, FUSECalib, FUSEBioMedInst, FUSEDCSPWR, FUSEFCO2H2Reg, FUSEFCO2H2HTR, AGENAPWR, AGENASquib1, AGENASquib2, AGENACntl,
        FUSERadarPWR, FUSEACMEInv, FUSERCSHTRSA, FUSERCSHTRSB, FUSETapeRecorderPWR, FUSETapeRecorderCNTL, FUSEFuelCellCntl1, FUSEFuelCellCntl2, FUSEFCdP, AGENAEncoder, AGENAExtrLts,
        FDI2Switch, FUSEBioMedRcdr1, FUSEBioMedRcdr2, FUSERCSHtr, AGENAIndexEvaBars, AGENAEngineARM, AGENABusArm,
        RadarLockOn, TDAUndock, RateGyroPitch, RateGyroYaw, RateGyroRoll, UHFRadioSelect, HFAntennaSelect, RadioSilence, RadioKeying, RadioRecord,
        BeaconResc, BeaconSBand, BeaconCBand, TMCalib, TMSby, TMTM, RadioTapePlayback, RadioAntSel, HfAntControl, TDARigid,
        ABORTHandle, XOver
    };
    public enum GeminiButtonID
    {
        NULL, JettFairing, SepSpcft, IndRetroAtt, RCS, SepOAMSLine, SepElec, SepAdapt, ArmAutoRetro, JettRetro, ManFireRetro,
        Keyboard1, Keyboard2, Keyboard3, Keyboard4, Keyboard5, Keyboard6, Keyboard7, Keyboard8, Keyboard9, KeyboardZero,
        KeyboardReadOut, KeyboardClear, KeyboardEnter, ComputerReset, ComputerStart, PlatformReset, EmerRelease, DCSReceive, IMUReset,
        HiAltDrogue, Para, LdgAtt, ParaJett, EjectDRingCDR, EjectDRingPLT
    };
    public enum GeminiSelectorID
    {
        NULL, VoltMeterSelector, dPMeterSelector, CryoSelector, ACMEMode, IGSPlatform, ComputerMode, FDI1Mode, FDI1Data, FDI2Mode, FDI2Data,
        TapeControl, Repressurize, CabinRecirc, Snorkel, CabinVent, WaterSeal, O2HighRateRecock, EventTimerTimeKnob, MissionElapsedTimeKnob,
        PropGaugeSelector, FDI1SetKnob, FDI2SetKnob, DCDCConvATM, SecondaryO2ShutoffL, SecondaryO2ShutoffR, EncoderBit1, EncoderBit2, EncoderBit3,
        RadioModeA, RadioModeB, DimLightControl, TempCabin, TempSuit
    };

    public enum CommandModuleSwitchID
    {
        NULL, FC1MNA, FC2MNA, FC3MNA, FC1MNB, FC2MNB, FC3MNB, Inverter1MNA, Inverter2MNB, Inverter3MNAMNB, ACBus1Inv1, ACBus1Inv2, ACBus1Inv3, ACBus2Inv1, ACBus2Inv2, ACBus2Inv3,
        FC1Htr, FC2Htr, FC3Htr, FC1ReactantShutoff, FC2ReactantShutoff, FC3ReactantShutoff, FCReacsValves, CryoH2Htr1, CryoH2Htr2, CryoO2Htr1, CryoO2Htr2, CryoH2Fan1, CryoH2Fan2,
        CryoO2Fan1, CryoO2Fan2, FCRadiator1, FCRadiator2, FCRadiator3, FC1Purge, FC2Purge, FC3Purge, H2PurgeLineHtr, GnNOpticsPWR, GnNIMUPWR, PrplntDumpAuto, TwoEngOut, LVRates, TwrJett1, TwrJett2,
        LVSPSIndaPc, LVSPSIncSIISIV_GP1, CMCAtt, IMUCage, Guidance, SII_SIVBStage, EDS, GNLightACPWR, FDAIScale, FDAISelect, FDAISource, ATTSet, AutoRCSA1, AutoRCSA2, AutoRCSA3, AutoRCSA4,
        AutoRCSB1, AutoRCSB2, AutoRCSB3, AutoRCSB4, AutoRCSC1, AutoRCSC2, AutoRCSC3, AutoRCSC4, AutoRCSD1, AutoRCSD2, AutoRCSD3, AutoRCSD4, SigCondDriverBiasPWR1, SigCondDriverBiasPWR2,
        RCSCommand, RotCntlPWR_Normal1, RotCntlPWR_Normal2, RotCntlPWR_Direct1, RotCntlPWR_Direct2, TransCntlPWR, SCCont, EDSPower, SMRCSHe1A, SMRCSHe1B, SMRCSHe1C, SMRCSHe1D, SMRCSHe2A,
        SMRCSHe2B, SMRCSHe2C, SMRCSHe2D, SMRCSPrplnt1A, SMRCSPrplnt1B, SMRCSPrplnt1C, SMRCSPrplnt1D, SMRCSPrplnt2A, SMRCSPrplnt2B, SMRCSPrplnt2C, SMRCSPrplnt2D, CMPrplntT1, CMPrplntT2,
        SM_RCSIndSel, SM_RCS_Heater_A, SM_RCS_Heater_B, SM_RCS_Heater_C, SM_RCS_Heater_D, AttRate, AttDeadband, AttCycleLimiter, AttManualRoll, AttManualPitch, AttManualYaw, CMCMode,
        BMAGRoll, BMAGPitch, BMAGYaw, TVCPitch, TVCYaw, TVCGimbalMotorsPitch1, TVCGimbalMotorsPitch2, TVCGimbalMotorsYaw1, TVCGimbalMotorsYaw2, TVCGimbalDrivePitch, TVCGimbalDriveYaw,
        TVCServo1, TVCServo2, EventTimerP1_DirectionReset, EventTimerP1_StartStop, EventTimerP1_ModifyMin, EventTimerP1_ModifySec, SPSDirectOn, SPSdVThrustA, SPSdVThrustB, SPSHeVlv1, SPSHeVlv2,
        SPSPSIInd, SPSLineHtrs, SPSTest, SPSOxidFlow, SPSOxidPrimAux, SPSPUGMode, TM_Hrs, TM_Min, TM_Sec, SIVB_LMSep, EMSSetting, EMS_GTA, CM_SM_Sep1, CM_SM_Sep2, CW_Mode, CW_CSM_SM, CW_PWR, CW_LampTest,
        MSNTimerStart, RCSTransfer, CM_RCS_Press, RCSLogic, CM_RCS_Heaters, ELSLogic, ELSAuto, SeqLogic1, SeqLogic2, PyroArmA, PyroArmB, FloatBag1, FloatBag2, FloatBag3, CMRCSPrplntDump, CMRCSPrplntPurge,
        GlycolEvapTempInAuto, O2PressInd, CabinFan1, CabinFan2, SuitCircHeatExch, H2OAccumAuto, H2OAccumPWR, PotH2OHtr, GlycolEvapH2OFlow, H2OWaterQtyInd, SecCoolLoopEvap, SecCoolPumpAC,
        GycolEvapSteamPressAuto, GycolEvapSteamPressMod, CabinTempAuto, FuelCellPumpA, FuelCellPumpB, FuelCellPumpC, BatteryChargerAC, RadiatorFlowContPower, RadiatorFlowContSelector,
        RadiatorManSel, RadiatorHeaterPrimary, RadiatorHeaterSecondary, Radio1Mode, Radio1PadComm, Radio1SBand, Radio1Power, Radio1Intercom, Radio1VHF, Radio1AudioControl, Radio1Suit, Radio1VHFRange,
        Radio2Mode, Radio2PadComm, Radio2SBand, Radio2Power, Radio2Intercom, Radio2VHF, Radio2AudioControl, Radio2Suit, HighGainTrack, HighGainBeam, HighGainServoPwr, HighGainServoSel,
        SBandNormalXpndr, SBandNormalPwrAmplSel, SBandNormalPwrAmplStr, SBandNormalModeVoiceRelay, SBandNormalModePCMKey, SBandNormalModeRng, SBandAUXTapeDNVoiceBU, SBandAUXTVSCI, UpTlmDataDNVoicedBU, UpTlmCmd,
        SBandAntennaOmniABC, SBandAntennaOmniDHiG, SqA_VHFAmA, SqA_VHFAmB, SqA_RcvOnly, SqA_VHFBcn, SqA_VHFRanging, SqB_TapeRec_ANLG_LM, SqB_PlayMode, SqB_TapeSpool, SqB_PwrSCE, SqB_PwrPMP, SqB_PCMBitRate,
        DockingProbeExtend, DockingProbeRetractPrim, DockingProbeRetractSec, ExtLightRUNEVA, ExtLightRNDZ, TunnelLights, LMPower, UpTlm_IU, UpTlm_CM, LogicPower23, Dot05gAllowed, EMSRoll,
        SPSGauging, TelecomGroup1, TelecomGroup2, SuitCompressor1, SuitCompressor2, MainChuteRelease, NonEssBus, MainBusTieAC, MainBusTieBC, MNAUndervoltSensor, MNBUndervoltSensor,
        ORDEAL_FDAI1, ORDEAL_FDAI2, ORDEAL_Mode, ORDEAL_Lighting, ORDEAL_Slew, ORDEAL_Location, CSMLMSep1, CSMLMSep2, XLunarInject,
        //TSS
        WasteH2ODumpHtr, UrineDumpHtr, P3_ACBus1Reset, P3_ACBus2Reset,
        P122_OpticsMode, P122_ControllerSpeed, P122_ControllerCoupling, P122_Tracker, P122_TelescopeTrunnion, P122_ConditionLamps, P122_OpticsUptlm,
        P300_OxygenFlow, P301_OxygenFlow, P302_OxygenFlow,
        P100_UtilityPower, P100_FloodDim, P100_FloodFixed, P100_RendzTpndr, P306_TM_Hrs, P306_TM_Min, P306_TM_Sec, P306_TM_Start,
        P306_EventTimer_DirectionReset, P306_EventTimer_StartStop, P306_EventTimer_ModifyMin, P306_EventTimer_ModifySec,
        P101_RndzXpndrTest, P15_CoasPower, P15_UtilityPower, P15_BeaconLight, P15_DyeMarker, P15_Vent, P376_PLVC,
        P16_DockingTarget, P16_Utility, P16_CoasPower, P227_SCIInst, P180_SBandSquelch, P162_SCIPower, P163_SCIPower,
        P8_FloodDim, P8_FloodFixed, P1_dVCG, P5_FloodDim, P5_FloodFixed,
        P600_EmerO2Valve, P601_RepressO2Valve
    };
    public enum CommandModuleButtonID
    {
        NULL, AGCVerb, AGCNoun, AGCPluss, AGCMinus, AGC0, AGC1, AGC2, AGC3, AGC4, AGC5, AGC6, AGC7, AGC8, AGC9, AGCClear, AGCPro, AGCKeyRel, AGCEntr, AGCRset,
        Liftoff, NoAutoAbort, LESMotorFire, CanardDeploy, CSMLVSep, APEXCoverJett, DrogueDeploy, MainDeploy, CMRCSHeDump, GDCAlign, SPSDirectUllage, SPSThrustOn,
        EMS_Increase, EMS_Decrease, EMS_IncreaseFast, EMS_DecreaseFast, MasterCaution, Abort, P351_EmerCabinPressTest, P380_DemandRegulatorBleedPort
    };
    public enum CommandModuleCircuitBreakerID
    {
        NULL, FC1Reacs, FC2Reacs, FC3Reacs, FC1BusCont, FC2BusCont, FC3BusCont, InvCtrl1, InvCtrl2, InvCtrl3, CryoH2Htr1, CryoH2Htr2, CryoO2Htr1, CryoO2Htr2,
        CryoFan10A, CryoFan10B, CryoFan10C, CryoFan20A, CryoFan20B, CryoFan20C, O2VACIONPumpMNA, O2VACIONPumpMNB, FC1Radiator, FC2Radiator, FC3Radiator, FC1Purge, FC2Purge, FC3Purge,
        CMCMNA, CMCMNB, IMUMNA, IMUMNB, OSSMNA, OSSMNB, GnNPWRAC1, GnNPWRAC2, SCSAC1, SCSAC2, Controller1DirectMNA, Controller1DirectMNB, Controller2DirectMNA, Controller2DirectMNB,
        ACRollMNA, ACRollMNB, BDRollMNA, BDRollMNB, PitchMNA, PitchMNB, YawMNA, YawMNB, RCSLogicMNA, RCSLogicMNB, PrplntIsolMNA, PrplntIsolMNB, ControllerAutoMNA, ControllerAutoMNB,
        QuadAHeaters, QuadBHeaters, QuadCHeaters, QuadDHeaters, SPSHeVlvMNA, SPSHeVlvMNB, SPSPilotVlvMNA, SPSPilotVlvMNB, DirectUllageMNA, DirectUllageMNB, TVCAC1, TVCAC2,
        CMHtr1, CMHtr2, SeqLogic1, SeqLogic2, PyroArmA, PyroArmB, FloatBag1, FloatBag2, FloatBag3, ELSBatA, ELSBatB, CabinFan1A, CabinFan1B, CabinFan1C, CabinFan2A, CabinFan2B, CabinFan2C,
        SecCoolLoopAC1, SecCoolLoopAC2, WasteH2OUrineDumpMNA, WasteH2OUrineHtrMNB, XducerSecCoolLoopMNA, XducerSecCoolLoopMNB, WastePotH2OMNA, WastePotH2OMNB, XducerPressGroup1MNA, XducerPressGroup1MNB,
        XducerPressGroup2MNA, XducerPressGroup2MNB, XducerTempMNA, XducerTempMNB, PotWaterHtrMNA, PotWaterHtrMNB, WaterAccumulatorMNA, WaterAccumulatorMNB, EPSSensorDCMNA, EPSSensorDCMNB,
        EPSSensorAC1, EPSSensorAC2, CnWSDCMNA, CnWSDCMNB, EPSSensorUnitDCMNA, EPSSensorUnitDCMNB, EPSSensorUnitAC1, EPSSensorUnitAC2, BatteryRelayBus_BatA, BatteryRelayBus_BatB,
        BatteryChargerMainAC, BatteryChargerMNA, BatteryChargerMNB, BatteryChargeA, BatteryChargeB, RadiatorControllerAC1, RadiatorControllerAC2, RadiatorControllerHtrMNA, RadiatorControllerHtrMNB,
        RadiatorHtrsOvldBatA, RadiatorHtrsOvldBatB, SCSSystemMNA, SCSSystemMNB, SCSLogic12MNA, SCSLogic12MNB, SCSLogic34MNA, SCSLogic34MNB, EMSMNA, EMSMNB, DockProbeMNA, DockProbeMNB,
        MainABatBusA, MainABatC, MainBBatC, MainBBatBusB, FlgtPstLndBatBusA, FlgtPstLndBatBusB, FlgtPstLndBatC, FlgtPstLndMainA, FlgtPstLndMainB, InvPwr1MainA, InvPwr2MainB, InvPwr3MainA, InvPwr3MainB,
        PyroA_BatBusAToPyroBusTie, PyroA_SeqA, PyroB_BatBusBToPyroBusTie, PyroB_SeqB, BatAPwrEntPstLnd, BatBPwrEntPstLnd, BatCPwrEntPstLnd, BatCToBatBusA, BatCToBatBusB, BatCBatChargerEDS2,
        InstPwrCntrlCB1, InstPwrCntrlCB2, InstPwrCntrlCB3, InstPwrCntrlCB4, UprightSystem1, UprightSystem2, SIVLMSepPyroA, SIVLMSepPyroB, PrimaryGlycolToRadiators, PLVentFLTPL,
        EDSBatA, EDSBatB, EDSBatC, ORDEALAC2, ORDEALMNB, LM_PWR_1_MNA, LM_PWR_2_MNB,
        P225_CommPCM_TLM_Group1, P225_CommPCM_TLM_Group2, P225_FlightBusMNA, P225_FlightBusMNB, P225_PMPPowerFLTBUSPrim, P225_PMPPowerFLTBUSAux, P225_SBandFMXMTR_DataStorageEquipGroup1,
        P225_SBandFMXMTR_DataStorageEquipFltBus, P225_HighGainAnt_Group2, P225_HighGainAnt_FltBus, P225_UDLFltBus, P225_VHFCrewStationAudio_FltPostLdgBus_L,
        P225_VHFCrewStationAudio_FltPostLdgBus_CTR, P225_VHFCrewStationAudio_FltPostLdgBus_R, P225_SBandPwrAmplPhaseMDOXpndr2Group2, P225_SBandPwrAmplPhaseMDOXpndr2FltBus,
        P225_SBandPwrAmplPhaseMDOXpndr1Group1, P225_SBandPwrAmplPhaseMDOXpndr1FltBus, P225_CentralTimingEquip_MNA, P225_CentralTimingEquip_MNB, P225_RndzXpndrFltBus,
        P225_SigCondrFltBus, P226_ACPumpFC1, P226_ACPumpFC2, P226_ACPumpFC3, P226_FuseQtyAmpl1_AC1, P226_FuseQtyAmpl2_AC2,
        P226_LightningCoasTunnelRndzSpotMNA, P226_LightningCoasTunnelRndzSpotMNB, P226_LightNumIntgMDCAC1R, P226_LightNumIntgMDCAC1L,
        P226_LightNumIntgLEBAC2, P226_LightFloodFltPl, P226_LightFloodMNB, P226_LightFloodMNA, P226_LightRunEvaTrgtAC1, P226_LightRunEvaTrgtAC2,
        P229_SPSLineHtrsMNA, P229_SPSLineHtrsMNB, P229_TimersMNA, P229_TimersMNB, P229_EPSGroup2MNA, P229_EPSGroup1MNA, P229_EPSGroup2MNB, P229_EPSGroup1MNB,
        P229_EPSGroup4MNA, P229_EPSGroup3MNA, P229_EPSGroup4MNB, P229_EPSGroup3MNB, P229_MainReleasePyroA, P229_MainReleasePyroB, P229_EPSGroup5MNA,
        P229_EPSGroup5MNB, P229_EPSUtilityRLSTA, P229_EPSUtilityLEB, P229_EPSBatBusB, P229_EPSBatBusA, P380_SuitCurcuitReturnValve,
        P4_SuitCompAC1A, P4_SuitCompAC1B, P4_SuitCompAC1C, P4_SuitCompAC2A, P4_SuitCompAC2B, P4_SuitCompAC2C,
        P4_ECSGlycolPumpAC1A, P4_ECSGlycolPumpAC1B, P4_ECSGlycolPumpAC1C, P4_ECSGlycolPumpAC2A, P4_ECSGlycolPumpAC2B, P4_ECSGlycolPumpAC2C,
        P5_SecCoolLoopRadHtrMNA, P5_GN_ImuHtr_MNA, P5_GN_ImuHtr_MNB,
        P8_SPS_GaugingMNA, P8_SPS_GaugingMNB, P8_SPS_GaugingAC1, P8_SPS_GaugingAC2, P8_SPS_Pitch1BatA, P8_SPS_Pitch2BatB, P8_SPS_Yaw1BatA, P8_SPS_Yaw2BatB,
        P5_Inst_EssMNA, P5_Inst_EssMNB, P5_Inst_NonEss, P5_Inst_SCI1, P5_Inst_SCI2, P5_Inst_SCIHatch
    };
    public enum CommandModuleSelectorID
    {
        NULL, FCTestSelector, DCIndicatorSelector, ACIndicatorSelector, FDAIPowerSelector, SCSElectronicsPWR, RCSIndicatorSelector, IntegralLeft, IntegralCenter, IntegralRight,
        FloodLeft, FloodInside, FloodRight, BMAGPWR1, BMAGPWR2, EMSSelector, PrimaryRCSGlycolPumps, ChargeBatterySelector, ECSIndicatorSelector, HighGainPitch, HighGainYaw,
        WheelSqA, WheelSqB, WheelCabinTemp, SPSGimbalTrimPitch, SPSGimbalTrimYaw, VHFAntennaSelector, LM_CM_PSI_DiffSelector, CM_LM_DoorHatch, P377_GlyToRadSec, P7_DirectO2,
        P378_PrimGlycolAccum, P379_PrimAccumFill, P382_SuitHtExchPrimaryGlycol, P382_SuitFlow, P382_PrimaryGlycolEvapInletTemperature, P382_SuitHtExchSecondaryGlycol,
        P382_EvapWaterControlPrimary, P382_EvapWaterControlSecondary, P382_WaterAccumulator1, P382_WaterAccumulator2,
        P351_MNRegulatorA, P351_MNRegulatorB, P351_Regulator, P351_Relief, P351_EmerCabinPSI, P351_CabinRepress,
        P352_WasteTank, P352_PotableTank, P352_WasteTankInlet, P352_PressureRelief, P303_PrimaryCabinTemp, P303_SecondaryCabinTemp, P304_DrinkingWaterSupply,
        P100_Numerics, P101_SysTest1, P101_SysTest2, P375_OxygenSurgeVlv, P380_DemandReg, P380_O2DemandReg, P325_CabinPressureRelief1, P325_CabinPressureRelief2,
        P326_GlycolReservoir_Inlet, P326_GlycolReservoir_Bypass, P326_GlycolReservoir_Outlet,
        P326_OxygenRepressPkg, P326_OxygenSMSupply, P326_OxygenSurgeTank, P251_WasteMngtOvdbDump, P252_BatteryVent, P252_WasteStowageVent,
        P8_Numerics, P350_CO2CannisterA, P350_CO2CannisterB, SideHatch_VentValve
    };



    public enum LunarModuleSwitchID
    {
        NULL, P14_EDVolts, P14_Inverter, P14_DescentBat1LMPHiV, P14_DescentBat1LMPLoV, P14_DescentBat2LMP, P14_DescentBat3CDR, P14_DescentBat4CDRHiV, P14_DescentBat4CDRLoV, P14_DescentBatLunarCDR, P14_DescentBatLunarLMP,
        P14_DesBayDeadface, P14_AscentBat5NormalLMPFeed, P14_AscentBat5BackupCDRFeed, P14_AscentBat6NormalCDRFeed, P14_AscentBat6BackupLMPFeed, P14_UplinkSquelch,
        P02_SysA_ASCFeed1, P02_SysA_ASCFeed2, P02_SysA_Q1, P02_SysA_Q2, P02_SysA_Q3, P02_SysA_Q4, P02_SysB_ASCFeed1, P02_SysB_ASCFeed2, P02_SysB_Q1, P02_SysB_Q2, P02_SysB_Q3, P02_SysB_Q4, P02_Crossfeed, P02_MainSOV_SysA, P02_MainSOV_SysB, P02_ACAProp,
        P03_RCS_Heaters_Q1, P03_RCS_Heaters_Q2, P03_RCS_Heaters_Q3, P03_RCS_Heaters_Q4,
        P01_AttTransFourTwoJetMode, P08_DesPropulsion_FuelVent, P08_DesPropulsion_OxidVent, P08_DesPrplnt_IsolVlv, P08_MasterArm, P08_DesVent, P08_ASCHeSel,
        P08_LandingGearDeploy, P08_HePRESS_RCS, P08_HePRESS_DesStart, P08_HePRESS_Ascent, P08_Stage, P08_StageRelay,
        P01_PrplntQtyMon, P01_PrplntTempMon, P01_AscentHeReg1, P01_AscentHeReg2, P01_DescentHeReg1, P01_DescentHeReg2, P03_DesEngCmdOvrd, P03_EngGmbl, P01_EngineThrustCont_ThrCont_ThrCont, P01_EngineThrustCont_ManThrot, P01_EngineThrustCont_EngArm, P01_EngineThrustCont_BalCpl,
        P03_DeadBand, P03_GyroTest_Attitude, P03_GyroTest_Rate, P03_AttitudeControl_Roll, P03_AttitudeControl_Pitch, P03_AttitudeControl_Yaw, P03_ModeControl_PGNS, P03_ModeControl_AGS, P03_IMUCage,
        P01_GuidCont, P01_ModeSel, P01_RngAltMon, P01_RateErrMon, P01_AltitudeMon, P01_RateScale, P01_ACAProp, P01_ShfTrun, P02_RateErrMon, P02_AltitudeMon,
        P03_LandingAnt, P03_RadarTest, P03_SlewRate, P03_Slew, P03_EventTimer_CountDir_Reset, P03_EventTimer_TimerCount, P03_EventTimer_SlewCountMin, P03_EventTimer_SlewCountSec, P03_SidePanels, P03_Lighting_Flood_OvhdFwd, P03_Lighting_Exterior, P03_XPointerScale,
        P08_Audio_Replay, P08_Coas, P08_Audio_SBand, P08_Audio_ICS, P08_Audio_VHFA, P08_Audio_VHFB, P08_Audio_CommMode, P08_Audio_AudioCont,
        P12_Audio_Replay, P12_Audio_SBand, P12_Audio_ICS, P12_Audio_AudioCont, P12_Audio_CommMode, P12_Audio_VHFA, P12_Audio_VHFB, P12_Audio_UpdataLink,
        P12_Comm_Modulate, P12_Comm_XmitRcvr, P12_Comm_PwrAmpl, P12_Comm_FuncVoice, P12_Comm_FuncPCM, P12_Comm_Range, P12_Comm_VHF_A_Xmtr, P12_Comm_VHF_A_Rcvr, P12_Comm_VHF_B_Xmtr, P12_Comm_VHF_B_Rcvr, P12_Comm_TelemetryBiomed, P12_Comm_TelemetryPCM, P12_Comm_TrackMode, P12_Comm_Recorder,
        P06_AGS_Status, P04_CDR_ACA, P04_CDR_TTCA, P04_LMP_ACA, P04_LMP_TTCA,
        P05_MissionTimer_TimerCont, P05_MissionTimer_Hours, P05_MissionTimer_Min, P05_MissionTimer_Sec,
        P05_Lighting_Sidepanels, P05_Lighting_Integral, P05_Lighting_Num, P05_Lighting_Anun, P05_DesRate, P01_XPointerScale,
        ORDEAL_FDAI1, ORDEAL_FDAI2, ORDEAL_Mode, ORDEAL_Lighting, ORDEAL_Slew, ORDEAL_Location
    };
    public enum LunarModuleButtonID
    {
        NULL, AGSButton1, P05_StartEngine, P06_StopEngine, P05_StopEngine, P01_MasterAlarm, P02_MasterAlarm,
        LGCVerb, LGCNoun, LGCPlus, LGCNeg, LGC0, LGC1, LGC2, LGC3, LGC4, LGC5, LGC6, LGC7, LGC8, LGC9, LGCClr, LGCPro, LGCKeyRel, LGCEntr, LGCRset,
        P05_Transl, P01_Abort, P01_AbortStage, AGSButton0, AGSButton2, AGSButton3, AGSButton4, AGSButton5, AGSButton6, AGSButton7, AGSButton8, AGSButton9, AGSButtonHold, AGSButtonCLR, AGSButtonReadOut, AGSButtonEntr, AGSButtonPos, AGSButtonNeg
    };
    public enum LunarModuleCircuitBreakerID
    {
        NULL, P16_BatFeedTieA, P16_BatFeedTieB, P16_CrossTieBalLoad, P16_CrossTieBus, P16_XLunarBusTie, P16_DesECACont, P16_DesECA, P16_AscECACont, P16_AscECA, P16_Inv2, P16_DCBusVolt, P16_Disp,
        P11_ACBusBBusTieInv1, P11_ACBusBBusTieInv2, P11_ACBusABusTieInv1, P11_ACBusABusTieInv2, P11_ACBusAACBusVolt,
        P11_BatFeedTieA, P11_BatFeedTieB, P11_CrossTieBalLoad, P11_CrossTieBus, P11_XLunarBusTie, P11_DesECACont, P11_DesECA, P11_AscECACont, P11_AscECA, P11_Inv1, P11_DCBusVolt,
        P16_Heaters_RCSAB2_Q1, P16_Heaters_RCSAB2_Q2, P16_Heaters_RCSAB2_Q3, P16_Heaters_RCSAB2_Q4, P16_Camr_Seq, P16_Heaters_SBandAnt, P16_Heaters_Disp,
        P16_Propul_ASCHe_Reg, P16_Propul_PQGS, P16_Propul_Disp, P16_RCSSysB_MainSov, P16_RCSSysB_PQGSDisp, P16_RCSSysB_TempPressDispFlags, P16_RCSSysB_Crossfeed,
        P16_RCSSysB_Q4, P16_RCSSysB_Q3, P16_RCSSysB_Q2, P16_RCSSysB_Q1, P16_RCSSysB_IsolVlv, P16_RCSSysB_ASCFeed2, P16_RCSSysB_ASCFeed1,
        P16_FltDisp_LMP_XPntr, P16_FltDisp_LMPFDAIAndEventTimer, P16_LTG_Flood, P16_LTG_Track, P16_LTG_AnunDockCompnt, P16_LTG_MasterAlarm, P16_ED_LogicPwrB,
        P16_StabCont_AEA, P16_StabCont_EngArm, P16_StabCont_ASA, P16_StabCont_AELD, P16_StabCont_ATCA, P16_StabCont_AbortStage, P16_StabCont_ATCA_AGS, P16_StabCont_DesEngOvrd,
        P16_Inst_CWEA, P16_Inst_SigSensor, P16_Inst_PCMTE, P16_Inst_SigCondr2, P16_ECS_SuitFlowCont, P16_ECS_CO2_Sensor, P16_ECS_DivertVlv, P16_ECS_CabinRepress, P16_ECS_CabinFanCont,
        P16_ECS_LCGPump, P16_ECS_GlycolPumpSec, P16_ECS_Disp, P16_SuitFan_dP, P16_ECS_SuitFan2,
        P16_Comm_TV, P16_Comm_PMP, P16_Comm_SBandAnt, P16_Comm_PrimSBand_XMTR_RCVR, P16_Comm_PrimSBand_PWPAmppl, P16_Comm_VHFB_RCVR, P16_Comm_VHFA_XMTR, P16_Comm_LMP_Audio, P16_Comm_Disp,
        P11_ACBusB_LMPWindHtr, P11_ACBusB_HePQGS_PropDisp, P11_ACBusB_SBandAnt, P11_ACBusB_Ordeal, P11_ACBusB_AGS, P11_ACBusB_LMPFDAI, P11_ACBusB_NumLtg, P11_ACBusB_AOTLMP,
        P11_ACBusA_CDRWindHtr, P11_ACBusA_TapeRcdr, P11_ACBusA_AOTLAMP, P11_ACBusA_RNDZRdr, P11_ACBusA_DecaGmbl, P11_ACBusA_IntglLtg, P11_ACBusA_CDRFDAI, P11_ACBusA_GASTA, P11_ACBusA_RngRtAltRt,
        P11_FlightDisplays_Ordeal, P11_FlightDisplays_COAS, P11_FlightDisplays_CDRFDAI, P11_FlightDisplays_GASTA, P11_FlightDisplays_RngRtAltRt, P11_FlightDisplays_CNDRXPntr,
        P11_FlightDisplays_MissionTimer, P11_FlightDisplays_Thrust,
        P11_RCSSysA_ASCFeed1, P11_RCSSysA_ASCFeed2, P11_RCSSysA_ISOLVlv, P11_RCSSysA_Q1TCA, P11_RCSSysA_Q2TCA, P11_RCSSysA_Q3TCA, P11_RCSSysA_Q4TCA, P11_RCSSysA_MainSov,
        P11_Prop_DESHeRegVent, P11_Heaters_RndzRdr_STB, P11_Heaters_RndzRdrOpr, P11_Heaters_LdgRdr, P11_Heaters_DockWindow, P11_Heaters_AOT, P11_Inst_SigCondr1,
        P11_StabCont_AEA, P11_StabCont_AbortStage, P11_StabCont_ATCA_PGNS, P11_StabCont_AELD, P11_StabCont_EngCont, P11_StabCont_AttDirCont, P11_StabCont_EngStartOvrd,
        P11_StabCont_DecaPWR, P11_ED_LdgGearFlag, P11_ED_LogicPWRA, P11_LTG_Util, P11_LTG_AnunDockCompnt,
        P11_PGNS_IMU_OPR, P11_PGNS_IMU_STBY, P11_PGNS_LGC_DSKY, P11_PGNS_RndzRdr, P11_PGNS_LdgRdr, P11_PGNS_SigStrDisp, P11_COMM_CDRAudio, P11_COMM_VHFARcvr, P11_COMM_VHFBXMTR,
        P11_COMM_SecSBand_PWRAmpl, P11_COMM_SecSBand_XMTR_RCVR, P11_COMM_UpDataLink,
        P11_ECS_GlycolPump_AutoTrnsfr, P11_ECS_GlycolPump_1, P11_ECS_GlycolPump_2, P11_ECS_CabinFan1, P11_ECS_SuitFan1, P11_Heaters_Q1, P11_Heaters_Q2, P11_Heaters_Q3, P11_Heaters_Q4,
        ECS_SuitGasDiverter, ECS_WaterSepSel
    };
    public enum LunarModuleSelectorID
    {
        NULL, P14_EPSPowerTempMon, P02_TempPressMon, P03_TempMonitor, P01_HeliumMon, P03_TestMonitor, P03_RndzRadar_Tracker, P03_LampToneTest, P03_FloodLightDimmer,
        P02_Glycol, P02_SuitFan, P02_O2_H2O_Qty_Mon, P05_FloodOvhdFwd, P05_AnunNum, P05_Integral, P12_Pitch, P12_Yaw, P12_SBand, P12_VHF,
        ECS_CabinRepress, ECS_PLSS_Fill, ECS_PressRegA, ECS_PressRegB, ECS_O2_Des, ECS_O2_Asc1, ECS_O2_Asc2, ECS_SuitIsol_CDR, ECS_SuitIsol_LMP, ECS_SecEvapFlow, ECS_PriEvapFlowNo2, ECS_DesH2O, ECS_PriEvapFlowNo1, ECS_SuitTemp, ECS_ASC_H2O,
        ECS_LiquidGarmentCooling, ECS_SuitCircuitRelief, ECS_CabinGasReturn, ECS_WaterTankSelector, TTCAThrottleJets, ForwardHatch_CabinReliefVentValve, OverheadHatch_CabinReliefVentValve, ECS_CO2CanisterSelect
    };





    public enum PinPosition { NULL, Left, Middle, Right, Up, Down };
    public enum CircuitBreakerPosition { NULL, Open, Closed }
}
