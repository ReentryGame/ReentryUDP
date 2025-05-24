use strum_macros::EnumIter;
use serde_derive::{Serialize, Deserialize};

#[derive(Debug, EnumIter, Deserialize, Serialize)]
pub enum Craft {
    Mercury, Gemini, CommandModule, LunarModule, SpaceShuttle, Vostok
}

#[derive(Debug, EnumIter, Deserialize, Serialize)]
pub enum MessageType {
    SetSwitch, PushButton, SetCircuitBreaker, SetSelector, SetHandle
}

#[derive(Debug, EnumIter, Deserialize, Serialize)]
pub enum PinPosition { NULL, Left, Middle, Right, Up, Down }

#[allow(non_snake_case)]
#[derive(Debug, Deserialize, Serialize)]
pub struct DataPacket {
    pub TargetCraft: u32,
    pub MessageType: u32,
    pub ID: u32,
    pub ToPos: u32
}

#[derive(Debug, EnumIter, Deserialize, Serialize)]
pub enum MercurySwitchID
{
    NULL, CabinLight, PhotoLight, LaunchControl, StbyBtry, IsolBtry, Ammeter,
    AudioBus, FansACBus, CabinFan, SuitFan, ASCSAC, ASCSMode, ASCSAuto, ASCSGyro,
    ArmSquib, RetroDelay, RetroAtt, AutoRetroJett, RetractScope, AttitudeSelect,
    WarningLightsBrightness, VOXSwitch, Beacon, Transmit, UHFSelect, UHFDF,
    TLMLoFreq, LandingBag, RescueAids, AudioCabinPress, AudioO2Emer, AudioFuelQuan,
    AudioRetroWarn, LightsTest, AudioH2OCabin, AudioH2OSuit, AudioRetroReset,
    InletValve, Maneuver, Battery1, Battery2, Battery3, Standby1, Standby2, IsolatedBattery
}

#[derive(Debug, EnumIter, Deserialize, Serialize)]
pub enum GeminiSwitchID
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
}

#[derive(Debug, EnumIter, Deserialize, Serialize)]
pub enum GeminiButtonID
{
    NULL, JettFairing, SepSpcft, IndRetroAtt, RCS, SepOAMSLine, SepElec, SepAdapt, ArmAutoRetro, JettRetro, ManFireRetro,
    Keyboard1, Keyboard2, Keyboard3, Keyboard4, Keyboard5, Keyboard6, Keyboard7, Keyboard8, Keyboard9, KeyboardZero,
    KeyboardReadOut, KeyboardClear, KeyboardEnter, ComputerReset, ComputerStart, PlatformReset, EmerRelease, DCSReceive, IMUReset,
    HiAltDrogue, Para, LdgAtt, ParaJett, EjectDRingCDR, EjectDRingPLT
}

#[derive(Debug, EnumIter, Deserialize, Serialize)]
pub enum CommandModuleSwitchID
{
    NULL, FC1MNA, FC2MNA, FC3MNA, FC1MNB, FC2MNB, FC3MNB, Inverter1MNA, Inverter2MNB, Inverter3MNAMNB, ACBus1Inv1, ACBus1Inv2, ACBus1Inv3, ACBus2Inv1, ACBus2Inv2, ACBus2Inv3,
    FC1Htr, FC2Htr, FC3Htr, FC1ReactantShutoff, FC2ReactantShutoff, FC3ReactantShutoff, FCReacsValves, CryoH2Htr1, CryoH2Htr2, CryoO2Htr1, CryoO2Htr2, CryoH2Fan1, CryoH2Fan2,
    CryoO2Fan1, CryoO2Fan2, FCRadiator1, FCRadiator2, FCRadiator3, FC1Purge, FC2Purge, FC3Purge, H2PurgeLineHtr, GnNOpticsPWR, GnNIMUPWR, PrplntDumpAuto, TwoEngOut, LVRates, TwrJett1, TwrJett2,
    LVSPSIndaPc, LVSPSIncSIISIVGP1, CMCAtt, IMUCage, Guidance, SIISIVBStage, EDS, GNLightACPWR, FDAIScale, FDAISelect, FDAISource, ATTSet, AutoRCSA1, AutoRCSA2, AutoRCSA3, AutoRCSA4,
    AutoRCSB1, AutoRCSB2, AutoRCSB3, AutoRCSB4, AutoRCSC1, AutoRCSC2, AutoRCSC3, AutoRCSC4, AutoRCSD1, AutoRCSD2, AutoRCSD3, AutoRCSD4, SigCondDriverBiasPWR1, SigCondDriverBiasPWR2,
    RCSCommand, RotCntlPWRNormal1, RotCntlPWRNormal2, RotCntlPWRDirect1, RotCntlPWRDirect2, TransCntlPWR, SCCont, EDSPower, SMRCSHe1A, SMRCSHe1B, SMRCSHe1C, SMRCSHe1D, SMRCSHe2A,
    SMRCSHe2B, SMRCSHe2C, SMRCSHe2D, SMRCSPrplnt1A, SMRCSPrplnt1B, SMRCSPrplnt1C, SMRCSPrplnt1D, SMRCSPrplnt2A, SMRCSPrplnt2B, SMRCSPrplnt2C, SMRCSPrplnt2D, CMPrplntT1, CMPrplntT2,
    SMRCSIndSel, SMRCSHeaterA, SMRCSHeaterB, SMRCSHeaterC, SMRCSHeaterD, AttRate, AttDeadband, AttCycleLimiter, AttManualRoll, AttManualPitch, AttManualYaw, CMCMode,
    BMAGRoll, BMAGPitch, BMAGYaw, TVCPitch, TVCYaw, TVCGimbalMotorsPitch1, TVCGimbalMotorsPitch2, TVCGimbalMotorsYaw1, TVCGimbalMotorsYaw2, TVCGimbalDrivePitch, TVCGimbalDriveYaw,
    TVCServo1, TVCServo2, EventTimerP1DirectionReset, EventTimerP1StartStop, EventTimerP1ModifyMin, EventTimerP1ModifySec, SPSDirectOn, SPSdVThrustA, SPSdVThrustB, SPSHeVlv1, SPSHeVlv2,
    SPSPSIInd, SPSLineHtrs, SPSTest, SPSOxidFlow, SPSOxidPrimAux, SPSPUGMode, TMHrs, TMMin, TMSec, SIVBLMSep, EMSSetting, EMSGTA, CMSMSep1, CMSMSep2, CWMode, CWCSMSM, CWPWR, CWLampTest,
    MSNTimerStart, RCSTransfer, CMRCSPress, RCSLogic, CMRCSHeaters, ELSLogic, ELSAuto, SeqLogic1, SeqLogic2, PyroArmA, PyroArmB, FloatBag1, FloatBag2, FloatBag3, CMRCSPrplntDump, CMRCSPrplntPurge,
    GlycolEvapTempInAuto, O2PressInd, CabinFan1, CabinFan2, SuitCircHeatExch, H2OAccumAuto, H2OAccumPWR, PotH2OHtr, GlycolEvapH2OFlow, H2OWaterQtyInd, SecCoolLoopEvap, SecCoolPumpAC,
    GycolEvapSteamPressAuto, GycolEvapSteamPressMod, CabinTempAuto, FuelCellPumpA, FuelCellPumpB, FuelCellPumpC, BatteryChargerAC, RadiatorFlowContPower, RadiatorFlowContSelector,
    RadiatorManSel, RadiatorHeaterPrimary, RadiatorHeaterSecondary, Radio1Mode, Radio1PadComm, Radio1SBand, Radio1Power, Radio1Intercom, Radio1VHF, Radio1AudioControl, Radio1Suit, Radio1VHFRange,
    Radio2Mode, Radio2PadComm, Radio2SBand, Radio2Power, Radio2Intercom, Radio2VHF, Radio2AudioControl, Radio2Suit, HighGainTrack, HighGainBeam, HighGainServoPwr, HighGainServoSel,
    SBandNormalXpndr, SBandNormalPwrAmplSel, SBandNormalPwrAmplStr, SBandNormalModeVoiceRelay, SBandNormalModePCMKey, SBandNormalModeRng, SBandAUXTapeDNVoiceBU, SBandAUXTVSCI, UpTlmDataDNVoicedBU, UpTlmCmd,
    SBandAntennaOmniABC, SBandAntennaOmniDHiG, SqAVHFAmA, SqAVHFAmB, SqARcvOnly, SqAVHFBcn, SqAVHFRanging, SqBTapeRecANLGLM, SqBPlayMode, SqBTapeSpool, SqBPwrSCE, SqBPwrPMP, SqBPCMBitRate,
    DockingProbeExtend, DockingProbeRetractPrim, DockingProbeRetractSec, ExtLightRUNEVA, ExtLightRNDZ, TunnelLights, LMPower, UpTlmIU, UpTlmCM, LogicPower23, Dot05gAllowed, EMSRoll,
    SPSGauging, TelecomGroup1, TelecomGroup2, SuitCompressor1, SuitCompressor2, MainChuteRelease, NonEssBus, MainBusTieAC, MainBusTieBC, MNAUndervoltSensor, MNBUndervoltSensor,
    ORDEALFDAI1, ORDEALFDAI2, ORDEALMode, ORDEALLighting, ORDEALSlew, ORDEALLocation, CSMLMSep1, CSMLMSep2, XLunarInject,
    //TSS
    WasteH2ODumpHtr, UrineDumpHtr, P3ACBus1Reset, P3ACBus2Reset,
    P122OpticsMode, P122ControllerSpeed, P122ControllerCoupling, P122Tracker, P122TelescopeTrunnion, P122ConditionLamps, P122OpticsUptlm,
    P300OxygenFlow, P301OxygenFlow, P302OxygenFlow,
    P100UtilityPower, P100FloodDim, P100FloodFixed, P100RendzTpndr, P306TMHrs, P306TMMin, P306TMSec, P306TMStart,
    P306EventTimerDirectionReset, P306EventTimerStartStop, P306EventTimerModifyMin, P306EventTimerModifySec,
    P101RndzXpndrTest, P15CoasPower, P15UtilityPower, P15BeaconLight, P15DyeMarker, P15Vent, P376PLVC,
    P16DockingTarget, P16Utility, P16CoasPower, P227SCIInst, P180SBandSquelch, P162SCIPower, P163SCIPower,
    P8FloodDim, P8FloodFixed, P1dVCG, P5FloodDim, P5FloodFixed,
    P600EmerO2Valve, P601RepressO2Valve
}

#[derive(Debug, EnumIter, Deserialize, Serialize)]
pub enum CommandModuleButtonID
{
    NULL, AGCVerb, AGCNoun, AGCPluss, AGCMinus, AGC0, AGC1, AGC2, AGC3, AGC4, AGC5, AGC6, AGC7, AGC8, AGC9, AGCClear, AGCPro, AGCKeyRel, AGCEntr, AGCRset,
    Liftoff, NoAutoAbort, LESMotorFire, CanardDeploy, CSMLVSep, APEXCoverJett, DrogueDeploy, MainDeploy, CMRCSHeDump, GDCAlign, SPSDirectUllage, SPSThrustOn,
    EMSIncrease, EMSDecrease, EMSIncreaseFast, EMSDecreaseFast, MasterCaution, Abort, P351EmerCabinPressTest, P380DemandRegulatorBleedPort
}
#[derive(Debug, EnumIter, Deserialize, Serialize)]
pub enum LunarModuleSwitchID
{
    NULL, P14EDVolts, P14Inverter, P14DescentBat1LMPHiV, P14DescentBat1LMPLoV, P14DescentBat2LMP, P14DescentBat3CDR, P14DescentBat4CDRHiV, P14DescentBat4CDRLoV, P14DescentBatLunarCDR, P14DescentBatLunarLMP,
    P14DesBayDeadface, P14AscentBat5NormalLMPFeed, P14AscentBat5BackupCDRFeed, P14AscentBat6NormalCDRFeed, P14AscentBat6BackupLMPFeed, P14UplinkSquelch,
    P02SysAASCFeed1, P02SysAASCFeed2, P02SysAQ1, P02SysAQ2, P02SysAQ3, P02SysAQ4, P02SysBASCFeed1, P02SysBASCFeed2, P02SysBQ1, P02SysBQ2, P02SysBQ3, P02SysBQ4, P02Crossfeed, P02MainSOVSysA, P02MainSOVSysB, P02ACAProp,
    P03RCSHeatersQ1, P03RCSHeatersQ2, P03RCSHeatersQ3, P03RCSHeatersQ4,
    P01AttTransFourTwoJetMode, P08DesPropulsionFuelVent, P08DesPropulsionOxidVent, P08DesPrplntIsolVlv, P08MasterArm, P08DesVent, P08ASCHeSel,
    P08LandingGearDeploy, P08HePRESSRCS, P08HePRESSDesStart, P08HePRESSAscent, P08Stage, P08StageRelay,
    P01PrplntQtyMon, P01PrplntTempMon, P01AscentHeReg1, P01AscentHeReg2, P01DescentHeReg1, P01DescentHeReg2, P03DesEngCmdOvrd, P03EngGmbl, P01EngineThrustContThrContThrCont, P01EngineThrustContManThrot, P01EngineThrustContEngArm, P01EngineThrustContBalCpl,
    P03DeadBand, P03GyroTestAttitude, P03GyroTestRate, P03AttitudeControlRoll, P03AttitudeControlPitch, P03AttitudeControlYaw, P03ModeControlPGNS, P03ModeControlAGS, P03IMUCage,
    P01GuidCont, P01ModeSel, P01RngAltMon, P01RateErrMon, P01AltitudeMon, P01RateScale, P01ACAProp, P01ShfTrun, P02RateErrMon, P02AltitudeMon,
    P03LandingAnt, P03RadarTest, P03SlewRate, P03Slew, P03EventTimerCountDirReset, P03EventTimerTimerCount, P03EventTimerSlewCountMin, P03EventTimerSlewCountSec, P03SidePanels, P03LightingFloodOvhdFwd, P03LightingExterior, P03XPointerScale,
    P08AudioReplay, P08Coas, P08AudioSBand, P08AudioICS, P08AudioVHFA, P08AudioVHFB, P08AudioCommMode, P08AudioAudioCont,
    P12AudioReplay, P12AudioSBand, P12AudioICS, P12AudioAudioCont, P12AudioCommMode, P12AudioVHFA, P12AudioVHFB, P12AudioUpdataLink,
    P12CommModulate, P12CommXmitRcvr, P12CommPwrAmpl, P12CommFuncVoice, P12CommFuncPCM, P12CommRange, P12CommVHFAXmtr, P12CommVHFARcvr, P12CommVHFBXmtr, P12CommVHFBRcvr, P12CommTelemetryBiomed, P12CommTelemetryPCM, P12CommTrackMode, P12CommRecorder,
    P06AGSStatus, P04CDRACA, P04CDRTTCA, P04LMPACA, P04LMPTTCA,
    P05MissionTimerTimerCont, P05MissionTimerHours, P05MissionTimerMin, P05MissionTimerSec,
    P05LightingSidepanels, P05LightingIntegral, P05LightingNum, P05LightingAnun, P05DesRate, P01XPointerScale,
    ORDEALFDAI1, ORDEALFDAI2, ORDEALMode, ORDEALLighting, ORDEALSlew, ORDEALLocation
}
#[derive(Debug, EnumIter, Deserialize, Serialize)]
pub enum LunarModuleButtonID
{
    NULL, AGSButton1, P05StartEngine, P06StopEngine, P05StopEngine, P01MasterAlarm, P02MasterAlarm,
    LGCVerb, LGCNoun, LGCPlus, LGCNeg, LGC0, LGC1, LGC2, LGC3, LGC4, LGC5, LGC6, LGC7, LGC8, LGC9, LGCClr, LGCPro, LGCKeyRel, LGCEntr, LGCRset,
    P05Transl, P01Abort, P01AbortStage, AGSButton0, AGSButton2, AGSButton3, AGSButton4, AGSButton5, AGSButton6, AGSButton7, AGSButton8, AGSButton9, AGSButtonHold, AGSButtonCLR, AGSButtonReadOut, AGSButtonEntr, AGSButtonPos, AGSButtonNeg
}