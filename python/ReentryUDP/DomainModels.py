from dataclasses import dataclass

@dataclass
class DataPacket:
    TargetCraft: int
    MessageType: int
    ID: int
    ToPos: int

class Craft:
    Mercury = 0
    Gemini = 1
    CommandModule = 2
    LunarModule = 3
    SpaceShuttle = 4
    Vostok = 5

class MessageType:
    SetSwitch = 0
    PushButton = 1

class Position:
    NULL = 0
    Left = 1
    Middle = 2
    Right = 3
    Up = 4
    Down = 5

class MercurySwitchID:
    NULL = 0
    CabinLight = 1
    PhotoLight = 2
    LaunchControl = 3
    StbyBtry = 4
    IsolBtry = 5
    Ammeter = 6
    AudioBus = 7
    FansACBus = 8
    CabinFan = 9
    SuitFan = 10
    ASCSAC = 11
    ASCSMode = 12
    ASCSAuto = 13
    ASCSGyro = 14
    ArmSquib = 15
    RetroDelay = 16
    RetroAtt = 17
    AutoRetroJett = 18
    RetractScope = 19
    AttitudeSelect = 20
    WarningLightsBrightness = 21
    VOXSwitch = 22
    Beacon = 23
    Transmit = 24
    UHFSelect = 25
    UHFDF = 26
    TLMLoFreq = 27
    LandingBag = 28
    RescueAids = 29
    AudioCabinPress = 30
    AudioO2Emer = 31
    AudioFuelQuan = 32
    AudioRetroWarn = 33
    LightsTest = 34
    AudioH2OCabin = 35
    AudioH2OSuit = 36
    AudioRetroReset = 37
    InletValve = 38
    Maneuver = 39
    Battery1 = 40
    Battery2 = 41
    Battery3 = 42
    Standby1 = 43
    Standby2 = 44
    IsolatedBattery = 45

class GeminiSwitchID:
    NULL = 0
    FUSECoaxCntl = 1
    SquibBoostInsert = 2
    SquibRetroPWR = 3
    SquibRetroJett = 4
    SquibLanding = 5
    SquibRetro1 = 6
    SquibRetro2 = 7
    SquibRetro3 = 8
    SquibRetro4 = 9
    MainBattery1 = 10
    MainBattery2 = 11
    MainBattery3 = 12
    MainBattery4 = 13
    SquibBattery1 = 14
    SquibBattery2 = 15
    SquibBattery3 = 16
    LightsBrightness = 17
    LightsTest = 18
    FuelCell1PurgeO2 = 19
    FuelCell1PWR = 20
    FuelCell2PurgeO2 = 21
    FuelCell2PWR = 22
    FuelCell1A = 23
    FuelCell1B = 24
    FuelCell1C = 25
    FuelCell2A = 26
    FuelCell2B = 27
    FuelCell2C = 28
    BusTie1 = 29
    BusTie2 = 30
    ControllerPWROAMS = 31
    ControllerPWRRCSA = 32
    ControllerPWRRCSB = 33
    ACPowerSource = 34
    MDIUPower = 35
    AuxTapePWR = 36
    ComputerPower = 37
    HorizonScannerSelect = 38
    HorizonScannerHeater = 39
    SuitFan = 40
    FUSESuitFan1 = 41
    FUSESuitFan2 = 42
    O2HighRate = 43
    CoolPriPumpA = 44
    CoolPriPumpB = 45
    CoolSecPumpA = 46
    CoolSecPumpB = 47
    RadiatorFlow = 48
    EvaporatorHeat = 49
    EvaporatprMaxFlow = 50
    EventTimerStart = 51
    EventTimerDirection = 52
    ElapsedTimeStarter = 53
    H2VacTank = 54
    CryoHeaterO2 = 55
    CryoHeaterH2 = 56
    OAMReg = 57
    PropMotoOAMS = 58
    PropMotRCSA = 59
    PropMotRCSB = 60
    FUSEDCDCConv = 61
    LightsCabin = 62
    LightsFDI = 63
    CTRLights = 64
    FUSEAudioAndUHFTR1 = 65
    FUSEAudioAndUHFTR2 = 66
    FUSEUHFRelay = 67
    FUSEToneVox = 68
    FUSETV = 69
    FUSEHFTR = 70
    FUSEAntCntl = 71
    FUSEWhipAntHF = 72
    FUSEWhipAntUHF = 73
    FUSEWhipAntDiplex = 74
    FUSEElectTimer = 75
    FUSEEventTimer = 76
    FUSEBoostCutoff1 = 77
    FUSEBoostCutoff2 = 78
    FUSERetroAuto = 79
    FUSERetroMan = 80
    FUSETr256 = 81
    FUSEECSIndLts = 82
    FUSEIndLtTest = 83
    FUSESeqLightsPWR = 84
    FUSESeqLightsCntl = 85
    FUSEParaCntl = 86
    FUSEAttIncCntlRetro = 87
    FUSEAttIndCntlLdg = 88
    FUSEBoostInsertCntl1 = 89
    FUSEBoostInsertCntl2 = 90
    FUSERetroSeqCntl1 = 91
    FUSERetroSeqCntl2 = 92
    FUSELandingSecCntl1 = 93
    FUSELandingSecCntl2 = 94
    FDI1Controller = 95
    GuidanceSwitch = 96
    FUSEBeaconsC = 97
    FUSEBeaconsResc = 98
    FUSEBeaconsAcq = 99
    FUSEAUXRecp = 100
    FUSECryQty = 101
    FUSECoolPumpSecB = 102
    FUSECoolPumpSecA = 103
    FUSECoolPumpPriB = 104
    FUSECoolPumpPriA = 105
    FUSETMAC = 106
    FUSEXmtrsDT = 107
    FUSEXmtrsRT = 108
    FUSEXmtrsStbyPWR = 109
    FUSEXmtrsStbyCntl = 110
    FUSEPriO2Htrs = 111
    FUSEH2OHtrs = 112
    FUSEClkLt = 113 
    FUSEOAMSHtrs = 114
    FUSEEvapThr = 115
    FUSECoolVlvsSec = 116
    FUSECoolVlvsPri = 117
    FUSEO2RateCntl = 118
    ACMEBiasPWR = 119
    RollJetsSelector = 120
    FUSEACMECntl1 = 121
    FUSEACMECntl2 = 122
    FUSEOAMSCntlProp = 123
    FUSEOAMSCntlReg1 = 124
    FUSEOAMSCntlReg2 = 125
    FUSERCSSquibs1 = 126
    FUSERCSSquibs2 = 127
    OAMSResvSwitch = 128
    FUSEManThru9 = 129
    FUSEManThru10 = 130
    FUSEManThru11 = 131
    FUSEManThru12 = 132
    FUSEManThru13 = 133
    FUSEManThru14 = 134
    FUSEManThru15 = 135
    FUSEManThru16 = 136
    AttitiudeDriversSwitch = 137
    FUSEAttThrust1 = 138
    FUSEAttThrust2 = 139
    FUSEAttThrust3 = 140
    FUSEAttThrust4 = 141
    FUSEAttThrust5 = 142
    FUSEAttThrust6 = 143
    FUSEAttThrust7 = 144
    FUSEAttThrust8 = 145
    ACMELogicYawSelector = 146
    ACMELogicPitchSelector = 147
    ACMELogicRollSelector = 148
    FUSERCSAPitch = 149
    FUSERCSAYawL = 150
    FUSERCSAYawR = 151
    FUSERCSBPitch = 152
    FUSERCSBYawL = 153
    FUSERCSBYawR = 154
    FUSEAUXTape = 155
    FUSESEOInst = 156
    FUSECalib = 157
    FUSEBioMedInst = 158
    FUSEDCSPWR = 159
    FUSEFCO2H2Reg = 160
    FUSEFCO2H2HTR = 161
    AGENAPWR = 162
    AGENASquib1 = 163
    AGENASquib2 = 164
    AGENACntl = 165
    FUSERadarPWR = 166
    FUSEACMEInv = 167
    FUSERCSHTRSA = 168
    FUSERCSHTRSB = 169
    FUSETapeRecorderPWR = 170
    FUSETapeRecorderCNTL = 171
    FUSEFuelCellCntl1 = 172
    FUSEFuelCellCntl2 = 173
    FUSEFCdP = 174
    AGENAEncoder = 175
    AGENAExtrLts = 176
    FDI2Switch = 177
    FUSEBioMedRcdr1 = 178
    FUSEBioMedRcdr2 = 179
    FUSERCSHtr = 180
    AGENAIndexEvaBars = 181
    AGENAEngineARM = 182
    AGENABusArm = 183
    RadarLockOn = 184
    TDAUndock = 185
    RateGyroPitch = 186
    RateGyroYaw = 187
    RateGyroRoll = 188
    UHFRadioSelect = 189
    HFAntennaSelect = 190
    RadioSilence = 191
    RadioKeying = 192
    RadioRecord = 193
    BeaconResc = 194
    BeaconSBand = 195
    BeaconCBand = 196
    TMCalib = 197
    TMSby = 198
    TMTM = 199
    RadioTapePlayback = 200
    RadioAntSel = 201
    HfAntControl = 202
    TDARigid = 203
    ABORTHandle = 204
    XOver = 205

class GeminiButtonID:
    NULL = 0
    JettFairing = 1
    SepSpcft = 2
    IndRetroAtt = 3
    RCS = 4
    SepOAMSLine = 5
    SepElec = 6
    SepAdapt = 7
    ArmAutoRetro = 8
    JettRetro = 9
    ManFireRetro = 10
    Keyboard1 = 11
    Keyboard2 = 12
    Keyboard3 = 13
    Keyboard4 = 14
    Keyboard5 = 15
    Keyboard6 = 16
    Keyboard7 = 17
    Keyboard8 = 18
    Keyboard9 = 19
    KeyboardZero = 20
    KeyboardReadOut = 21
    KeyboardClear = 22
    KeyboardEnter = 23
    ComputerReset = 24
    ComputerStart = 25
    PlatformReset = 26
    EmerRelease = 27
    DCSReceive = 28
    IMUReset = 29
    HiAltDrogue = 30
    Para = 31
    LdgAtt = 32
    ParaJett = 33
    EjectDRingCDR = 34
    EjectDRingPLT = 35


class CommandModuleSwitchID:
    NULL = 0
    FC1MNA = 1
    FC2MNA = 2
    FC3MNA = 3
    FC1MNB = 4
    FC2MNB = 5
    FC3MNB = 6
    Inverter1MNA = 7
    Inverter2MNB = 8
    Inverter3MNAMNB = 9
    ACBus1Inv1 = 10
    ACBus1Inv2 = 11
    ACBus1Inv3 = 12
    ACBus2Inv1 = 13
    ACBus2Inv2 = 14
    ACBus2Inv3 = 15
    FC1Htr = 16
    FC2Htr = 17
    FC3Htr = 18
    FC1ReactantShutoff = 19
    FC2ReactantShutoff = 20
    FC3ReactantShutoff = 21
    FCReacsValves = 22
    CryoH2Htr1 = 23
    CryoH2Htr2 = 24
    CryoO2Htr1 = 25
    CryoO2Htr2 = 26
    CryoH2Fan1 = 27
    CryoH2Fan2 = 28
    CryoO2Fan1 = 29
    CryoO2Fan2 = 30
    FCRadiator1 = 31
    FCRadiator2 = 32
    FCRadiator3 = 33
    FC1Purge = 34
    FC2Purge = 35
    FC3Purge = 36
    H2PurgeLineHtr = 37
    GnNOpticsPWR = 38
    GnNIMUPWR = 39
    PrplntDumpAuto = 40
    TwoEngOut = 41
    LVRates = 42
    TwrJett1 = 43
    TwrJett2 = 44
    LVSPSIndaPc = 45
    LVSPSIncSIISIVGP1 = 46
    CMCAtt = 47
    IMUCage = 48
    Guidance = 49
    SIISIVBStage = 50
    EDS = 51
    GNLightACPWR = 52
    FDAIScale = 53
    FDAISelect = 54
    FDAISource = 55
    ATTSet = 56
    AutoRCSA1 = 57
    AutoRCSA2 = 58
    AutoRCSA3 = 59
    AutoRCSA4 = 60
    AutoRCSB1 = 61
    AutoRCSB2 = 62
    AutoRCSB3 = 63
    AutoRCSB4 = 64
    AutoRCSC1 = 65
    AutoRCSC2 = 66
    AutoRCSC3 = 67
    AutoRCSC4 = 68
    AutoRCSD1 = 69
    AutoRCSD2 = 70
    AutoRCSD3 = 71
    AutoRCSD4 = 72
    SigCondDriverBiasPWR1 = 73
    SigCondDriverBiasPWR2 = 74
    RCSCommand = 75
    RotCntlPWRNormal1 = 76
    RotCntlPWRNormal2 = 77
    RotCntlPWRDirect1 = 78
    RotCntlPWRDirect2 = 79
    TransCntlPWR = 80
    SCCont = 81
    EDSPower = 82
    SMRCSHe1A = 83
    SMRCSHe1B = 84
    SMRCSHe1C = 85
    SMRCSHe1D = 86
    SMRCSHe2A = 87
    SMRCSHe2B = 88
    SMRCSHe2C = 89
    SMRCSHe2D = 90
    SMRCSPrplnt1A = 91
    SMRCSPrplnt1B = 92
    SMRCSPrplnt1C = 93
    SMRCSPrplnt1D = 94
    SMRCSPrplnt2A = 95
    SMRCSPrplnt2B = 96
    SMRCSPrplnt2C = 97
    SMRCSPrplnt2D = 98
    CMPrplntT1 = 99
    CMPrplntT2 = 100
    SMRCSIndSel = 101
    SMRCSHeaterA = 102
    SMRCSHeaterB = 103
    SMRCSHeaterC = 104
    SMRCSHeaterD = 105
    AttRate = 106
    AttDeadband = 107
    AttCycleLimiter = 108
    AttManualRoll = 109
    AttManualPitch = 110
    AttManualYaw = 111
    CMCMode = 112
    BMAGRoll = 113
    BMAGPitch = 114
    BMAGYaw = 115
    TVCPitch = 116
    TVCYaw = 117
    TVCGimbalMotorsPitch1 = 118
    TVCGimbalMotorsPitch2 = 119
    TVCGimbalMotorsYaw1 = 120
    TVCGimbalMotorsYaw2 = 121
    TVCGimbalDrivePitch = 122
    TVCGimbalDriveYaw = 123
    TVCServo1 = 124
    TVCServo2 = 125
    EventTimerP1DirectionReset = 126
    EventTimerP1StartStop = 127
    EventTimerP1ModifyMin = 128
    EventTimerP1ModifySec = 129
    SPSDirectOn = 130
    SPSdVThrustA = 131
    SPSdVThrustB = 132
    SPSHeVlv1 = 133
    SPSHeVlv2 = 134
    SPSPSIInd = 135
    SPSLineHtrs = 136
    SPSTest = 137
    SPSOxidFlow = 138
    SPSOxidPrimAux = 139
    SPSPUGMode = 140
    TMHrs = 141
    TMMin = 142
    TMSec = 143
    SIVBLMSep = 144
    EMSSetting = 145
    EMSGTA = 146
    CMSMSep1 = 147
    CMSMSep2 = 148
    CWMode = 149
    CWCSMSM = 150
    CWPWR = 151
    CWLampTest = 152
    MSNTimerStart = 153
    RCSTransfer = 154
    CMRCSPress = 155
    RCSLogic = 156
    CMRCSHeaters = 157
    ELSLogic = 158
    ELSAuto = 159
    SeqLogic1 = 160
    SeqLogic2 = 161
    PyroArmA = 162
    PyroArmB = 163
    FloatBag1 = 164
    FloatBag2 = 165
    FloatBag3 = 166
    CMRCSPrplntDump = 167
    CMRCSPrplntPurge = 168
    GlycolEvapTempInAuto = 169
    O2PressInd = 170
    CabinFan1 = 171
    CabinFan2 = 172
    SuitCircHeatExch = 173
    H2OAccumAuto = 174
    H2OAccumPWR = 175
    PotH2OHtr = 176
    GlycolEvapH2OFlow = 177
    H2OWaterQtyInd = 178
    SecCoolLoopEvap = 179
    SecCoolPumpAC = 180
    GycolEvapSteamPressAuto = 181
    GycolEvapSteamPressMod = 182
    CabinTempAuto = 183
    FuelCellPumpA = 184
    FuelCellPumpB = 185
    FuelCellPumpC = 186
    BatteryChargerAC = 187
    RadiatorFlowContPower = 188
    RadiatorFlowContSelector = 189
    RadiatorManSel = 190
    RadiatorHeaterPrimary = 191
    RadiatorHeaterSecondary = 192
    Radio1Mode = 193
    Radio1PadComm = 194
    Radio1SBand = 195
    Radio1Power = 196
    Radio1Intercom = 197
    Radio1VHF = 198
    Radio1AudioControl = 199
    Radio1Suit = 200
    Radio1VHFRange = 201
    Radio2Mode = 202
    Radio2PadComm = 203
    Radio2SBand = 204
    Radio2Power = 205
    Radio2Intercom = 206
    Radio2VHF = 207
    Radio2AudioControl = 208
    Radio2Suit = 209
    HighGainTrack = 210
    HighGainBeam = 211
    HighGainServoPwr = 212
    HighGainServoSel = 213
    SBandNormalXpndr = 214
    SBandNormalPwrAmplSel = 215
    SBandNormalPwrAmplStr = 216
    SBandNormalModeVoiceRelay = 217
    SBandNormalModePCMKey = 218
    SBandNormalModeRng = 219
    SBandAUXTapeDNVoiceBU = 220
    SBandAUXTVSCI = 221
    UpTlmDataDNVoicedBU = 222
    UpTlmCmd = 223
    SBandAntennaOmniABC = 224
    SBandAntennaOmniDHiG = 225
    SqAVHFAmA = 226
    SqAVHFAmB = 227
    SqARcvOnly = 228
    SqAVHFBcn = 229
    SqAVHFRanging = 230
    SqBTapeRecANLGLM = 231
    SqBPlayMode = 232
    SqBTapeSpool = 233
    SqBPwrSCE = 234
    SqBPwrPMP = 235
    SqBPCMBitRate = 236
    DockingProbeExtend = 237
    DockingProbeRetractPrim = 238
    DockingProbeRetractSec = 239
    ExtLightRUNEVA = 240
    ExtLightRNDZ = 241
    TunnelLights = 242
    LMPower = 243
    UpTlmIU = 244
    UpTlmCM = 245
    LogicPower23 = 246
    Dot05gAllowed = 247
    EMSRoll = 248
    SPSGauging = 249
    TelecomGroup1 = 250
    TelecomGroup2 = 251
    SuitCompressor1 = 252
    SuitCompressor2 = 253
    MainChuteRelease = 254
    NonEssBus = 255
    MainBusTieAC = 256
    MainBusTieBC = 257
    MNAUndervoltSensor = 258
    MNBUndervoltSensor = 259
    ORDEALFDAI1 = 260
    ORDEALFDAI2 = 261
    ORDEALMode = 262
    ORDEALLighting = 263
    ORDEALSlew = 264
    ORDEALLocation = 265
    CSMLMSep1 = 266
    CSMLMSep2 = 267
    XLunarInject = 268
    WasteH2ODumpHtr = 269
    UrineDumpHtr = 270
    P3ACBus1Reset = 271
    P3ACBus2Reset = 272
    P122OpticsMode = 273
    P122ControllerSpeed = 274
    P122ControllerCoupling = 275
    P122Tracker = 276
    P122TelescopeTrunnion = 277
    P122ConditionLamps = 278
    P122OpticsUptlm = 279
    P300OxygenFlow = 280
    P301OxygenFlow = 281
    P302OxygenFlow = 282
    P100UtilityPower = 283
    P100FloodDim = 284
    P100FloodFixed = 285
    P100RendzTpndr = 286
    P306TMHrs = 287
    P306TMMin = 288
    P306TMSec = 289
    P306TMStart = 290
    P306EventTimerDirectionReset = 291
    P306EventTimerStartStop = 292
    P306EventTimerModifyMin = 293
    P306EventTimerModifySec = 294
    P101RndzXpndrTest = 295
    P15CoasPower = 296
    P15UtilityPower = 297
    P15BeaconLight = 298
    P15DyeMarker = 299
    P15Vent = 300
    P376PLVC = 301
    P16DockingTarget = 302
    P16Utility = 303
    P16CoasPower = 304
    P227SCIInst = 305
    P180SBandSquelch = 306
    P162SCIPower = 307
    P163SCIPower = 308
    P8FloodDim = 309
    P8FloodFixed = 310
    P1dVCG = 311
    P5FloodDim = 312
    P5FloodFixed = 313
    P600EmerO2Valve = 314
    P601RepressO2Valve = 315

class CommandModuleButtonID:
    NULL = 0
    AGCVerb = 1
    AGCNoun = 2
    AGCPluss = 3
    AGCMinus = 4
    AGC0 = 5
    AGC1 = 6
    AGC2 = 7
    AGC3 = 8
    AGC4 = 9
    AGC5 = 10
    AGC6 = 11
    AGC7 = 12
    AGC8 = 13
    AGC9 = 14
    AGCClear = 15
    AGCPro = 16
    AGCKeyRel = 17
    AGCEntr = 18
    AGCRset = 19
    Liftoff = 20
    NoAutoAbort = 21
    LESMotorFire = 22
    CanardDeploy = 23
    CSMLVSep = 24
    APEXCoverJett = 25
    DrogueDeploy = 26
    MainDeploy = 27
    CMRCSHeDump = 28
    GDCAlign = 29
    SPSDirectUllage = 30
    SPSThrustOn = 31
    EMSIncrease = 32
    EMSDecrease = 33
    EMSIncreaseFast = 34
    EMSDecreaseFast = 35
    MasterCaution = 36
    Abort = 37
    P351EmerCabinPressTest = 38
    P380DemandRegulatorBleedPort = 39

class LunarModuleSwitchID:
    NULL = 0
    P14EDVolts = 1
    P14Inverter = 2
    P14DescentBat1LMPHiV = 3
    P14DescentBat1LMPLoV = 4
    P14DescentBat2LMP = 5
    P14DescentBat3CDR = 6
    P14DescentBat4CDRHiV = 7
    P14DescentBat4CDRLoV = 8
    P14DescentBatLunarCDR = 9
    P14DescentBatLunarLMP = 10
    P14DesBayDeadface = 11
    P14AscentBat5NormalLMPFeed = 12
    P14AscentBat5BackupCDRFeed = 13
    P14AscentBat6NormalCDRFeed = 14
    P14AscentBat6BackupLMPFeed = 15
    P14UplinkSquelch = 16
    P02SysAASCFeed1 = 17
    P02SysAASCFeed2 = 18
    P02SysAQ1 = 19
    P02SysAQ2 = 20
    P02SysAQ3 = 21
    P02SysAQ4 = 22
    P02SysBASCFeed1 = 23
    P02SysBASCFeed2 = 24
    P02SysBQ1 = 25
    P02SysBQ2 = 26
    P02SysBQ3 = 27
    P02SysBQ4 = 28
    P02Crossfeed = 29
    P02MainSOVSysA = 30
    P02MainSOVSysB = 31
    P02ACAProp = 32
    P03RCSHeatersQ1 = 33
    P03RCSHeatersQ2 = 34
    P03RCSHeatersQ3 = 35
    P03RCSHeatersQ4 = 36
    P01AttTransFourTwoJetMode = 37
    P08DesPropulsionFuelVent = 38
    P08DesPropulsionOxidVent = 39
    P08DesPrplntIsolVlv = 40
    P08MasterArm = 41
    P08DesVent = 42
    P08ASCHeSel = 43
    P08LandingGearDeploy = 44
    P08HePRESSRCS = 45
    P08HePRESSDesStart = 46
    P08HePRESSAscent = 47
    P08Stage = 48
    P08StageRelay = 49
    P01PrplntQtyMon = 50
    P01PrplntTempMon = 51
    P01AscentHeReg1 = 52
    P01AscentHeReg2 = 53
    P01DescentHeReg1 = 54
    P01DescentHeReg2 = 55
    P03DesEngCmdOvrd = 56
    P03EngGmbl = 57
    P01EngineThrustContThrContThrCont = 58
    P01EngineThrustContManThrot = 59
    P01EngineThrustContEngArm = 60
    P01EngineThrustContBalCpl = 61
    P03DeadBand = 62
    P03GyroTestAttitude = 63
    P03GyroTestRate = 64
    P03AttitudeControlRoll = 65
    P03AttitudeControlPitch = 66
    P03AttitudeControlYaw = 67
    P03ModeControlPGNS = 68
    P03ModeControlAGS = 69
    P03IMUCage = 70
    P01GuidCont = 71
    P01ModeSel = 72
    P01RngAltMon = 73
    P01RateErrMon = 74
    P01AltitudeMon = 75
    P01RateScale = 76
    P01ACAProp = 77
    P01ShfTrun = 78
    P02RateErrMon = 79
    P02AltitudeMon = 80
    P03LandingAnt = 81
    P03RadarTest = 82
    P03SlewRate = 83
    P03Slew = 84
    P03EventTimerCountDirReset = 85
    P03EventTimerTimerCount = 86
    P03EventTimerSlewCountMin = 87
    P03EventTimerSlewCountSec = 88
    P03SidePanels = 89
    P03LightingFloodOvhdFwd = 90
    P03LightingExterior = 91
    P03XPointerScale = 92
    P08AudioReplay = 93
    P08Coas = 94
    P08AudioSBand = 95
    P08AudioICS = 96
    P08AudioVHFA = 97
    P08AudioVHFB = 98
    P08AudioCommMode = 99
    P08AudioAudioCont = 100
    P12AudioReplay = 101
    P12AudioSBand = 102
    P12AudioICS = 103
    P12AudioAudioCont = 104
    P12AudioCommMode = 105
    P12AudioVHFA = 106
    P12AudioVHFB = 107
    P12AudioUpdataLink = 108
    P12CommModulate = 109
    P12CommXmitRcvr = 110
    P12CommPwrAmpl = 111
    P12CommFuncVoice = 112
    P12CommFuncPCM = 113
    P12CommRange = 114
    P12CommVHFAXmtr = 115
    P12CommVHFARcvr = 116
    P12CommVHFBXmtr = 117
    P12CommVHFBRcvr = 118
    P12CommTelemetryBiomed = 119
    P12CommTelemetryPCM = 120
    P12CommTrackMode = 121
    P12CommRecorder = 122
    P06AGSStatus = 123
    P04CDRACA = 124
    P04CDRTTCA = 125
    P04LMPACA = 126
    P04LMPTTCA = 127
    P05MissionTimerTimerCont = 128
    P05MissionTimerHours = 129
    P05MissionTimerMin = 130
    P05MissionTimerSec = 131
    P05LightingSidepanels = 132
    P05LightingIntegral = 133
    P05LightingNum = 134
    P05LightingAnun = 135
    P05DesRate = 136
    P01XPointerScale = 137
    ORDEALFDAI1 = 138
    ORDEALFDAI2 = 139
    ORDEALMode = 140
    ORDEALLighting = 141
    ORDEALSlew = 142
    ORDEALLocation = 143

class LunarModuleButtonID:
    NULL = 0
    AGSButton1 = 1
    P05StartEngine = 2
    P06StopEngine = 3
    P05StopEngine = 4
    P01MasterAlarm = 5
    P02MasterAlarm = 6
    LGCVerb = 7
    LGCNoun = 8
    LGCPlus = 9
    LGCNeg = 10
    LGC0 = 11
    LGC1 = 12
    LGC2 = 13
    LGC3 = 14
    LGC4 = 15
    LGC5 = 16
    LGC6 = 17
    LGC7 = 18
    LGC8 = 19
    LGC9 = 20
    LGCClr = 21
    LGCPro = 22
    LGCKeyRel = 23
    LGCEntr = 24
    LGCRset = 25
    P05Transl = 26
    P01Abort = 27
    P01AbortStage = 28
    AGSButton0 = 29
    AGSButton2 = 30
    AGSButton3 = 31
    AGSButton4 = 32
    AGSButton5 = 33
    AGSButton6 = 34
    AGSButton7 = 35
    AGSButton8 = 36
    AGSButton9 = 37
    AGSButtonHold = 38
    AGSButtonCLR = 39
    AGSButtonReadOut = 40
    AGSButtonEntr = 41
    AGSButtonPos = 42
    AGSButtonNeg = 43