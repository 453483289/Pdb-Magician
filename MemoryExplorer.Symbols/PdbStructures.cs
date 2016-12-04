using System;

namespace MemoryExplorer.Symbols
{
	#region HEADER
	public class CatalogueInformation
	{
		 public Guid Guid { get { return new Guid("afcb4fd7-b7a8-44ac-aa1a-4154cc109187"); } }
		 public uint Age { get { return 1; } }
		 public string MachineType { get { return @"Amd64"; } }
		 public string SymbolsFileName { get { return @"c:\temp\magician\afcb4fd7b7a844acaa1a4154cc1091871\ntkrnlmp.pdb"; } }
		 public uint Signature { get { return 1456230214; } }
	}
	#endregion
	#region _EPROCESS
 
	public class _EPROCESS
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _EPROCESS(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return _StructureData.Length; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_EPROCESS"": [ 1944, {
				 ""Pcb"": [ 0, [ ""_KPROCESS"", {}]],
				 ""ProcessLock"": [ 728, [ ""_EX_PUSH_LOCK"", {}]],
				 ""RundownProtect"": [ 736, [ ""_EX_RUNDOWN_REF"", {}]],
				 ""UniqueProcessId"": [ 744, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""ActiveProcessLinks"": [ 752, [ ""_LIST_ENTRY"", {}]],
				 ""Flags2"": [ 768, [ ""UInt32"", {}]],
				 ""JobNotReallyActive"": [ 768, [ ""BitField"", { ""end_bit"": 1, ""start_bit"": 0, ""target"": ""UInt32"" }]],
				 ""AccountingFolded"": [ 768, [ ""BitField"", { ""end_bit"": 2, ""start_bit"": 1, ""target"": ""UInt32"" }]],
				 ""NewProcessReported"": [ 768, [ ""BitField"", { ""end_bit"": 3, ""start_bit"": 2, ""target"": ""UInt32"" }]],
				 ""ExitProcessReported"": [ 768, [ ""BitField"", { ""end_bit"": 4, ""start_bit"": 3, ""target"": ""UInt32"" }]],
				 ""ReportCommitChanges"": [ 768, [ ""BitField"", { ""end_bit"": 5, ""start_bit"": 4, ""target"": ""UInt32"" }]],
				 ""LastReportMemory"": [ 768, [ ""BitField"", { ""end_bit"": 6, ""start_bit"": 5, ""target"": ""UInt32"" }]],
				 ""ForceWakeCharge"": [ 768, [ ""BitField"", { ""end_bit"": 7, ""start_bit"": 6, ""target"": ""UInt32"" }]],
				 ""CrossSessionCreate"": [ 768, [ ""BitField"", { ""end_bit"": 8, ""start_bit"": 7, ""target"": ""UInt32"" }]],
				 ""NeedsHandleRundown"": [ 768, [ ""BitField"", { ""end_bit"": 9, ""start_bit"": 8, ""target"": ""UInt32"" }]],
				 ""RefTraceEnabled"": [ 768, [ ""BitField"", { ""end_bit"": 10, ""start_bit"": 9, ""target"": ""UInt32"" }]],
				 ""DisableDynamicCode"": [ 768, [ ""BitField"", { ""end_bit"": 11, ""start_bit"": 10, ""target"": ""UInt32"" }]],
				 ""EmptyJobEvaluated"": [ 768, [ ""BitField"", { ""end_bit"": 12, ""start_bit"": 11, ""target"": ""UInt32"" }]],
				 ""DefaultPagePriority"": [ 768, [ ""BitField"", { ""end_bit"": 15, ""start_bit"": 12, ""target"": ""UInt32"" }]],
				 ""PrimaryTokenFrozen"": [ 768, [ ""BitField"", { ""end_bit"": 16, ""start_bit"": 15, ""target"": ""UInt32"" }]],
				 ""ProcessVerifierTarget"": [ 768, [ ""BitField"", { ""end_bit"": 17, ""start_bit"": 16, ""target"": ""UInt32"" }]],
				 ""StackRandomizationDisabled"": [ 768, [ ""BitField"", { ""end_bit"": 18, ""start_bit"": 17, ""target"": ""UInt32"" }]],
				 ""AffinityPermanent"": [ 768, [ ""BitField"", { ""end_bit"": 19, ""start_bit"": 18, ""target"": ""UInt32"" }]],
				 ""AffinityUpdateEnable"": [ 768, [ ""BitField"", { ""end_bit"": 20, ""start_bit"": 19, ""target"": ""UInt32"" }]],
				 ""PropagateNode"": [ 768, [ ""BitField"", { ""end_bit"": 21, ""start_bit"": 20, ""target"": ""UInt32"" }]],
				 ""ExplicitAffinity"": [ 768, [ ""BitField"", { ""end_bit"": 22, ""start_bit"": 21, ""target"": ""UInt32"" }]],
				 ""ProcessExecutionState"": [ 768, [ ""BitField"", { ""end_bit"": 24, ""start_bit"": 22, ""target"": ""UInt32"" }]],
				 ""DisallowStrippedImages"": [ 768, [ ""BitField"", { ""end_bit"": 25, ""start_bit"": 24, ""target"": ""UInt32"" }]],
				 ""HighEntropyASLREnabled"": [ 768, [ ""BitField"", { ""end_bit"": 26, ""start_bit"": 25, ""target"": ""UInt32"" }]],
				 ""ExtensionPointDisable"": [ 768, [ ""BitField"", { ""end_bit"": 27, ""start_bit"": 26, ""target"": ""UInt32"" }]],
				 ""ForceRelocateImages"": [ 768, [ ""BitField"", { ""end_bit"": 28, ""start_bit"": 27, ""target"": ""UInt32"" }]],
				 ""ProcessStateChangeRequest"": [ 768, [ ""BitField"", { ""end_bit"": 30, ""start_bit"": 28, ""target"": ""UInt32"" }]],
				 ""ProcessStateChangeInProgress"": [ 768, [ ""BitField"", { ""end_bit"": 31, ""start_bit"": 30, ""target"": ""UInt32"" }]],
				 ""DisallowWin32kSystemCalls"": [ 768, [ ""BitField"", { ""end_bit"": 32, ""start_bit"": 31, ""target"": ""UInt32"" }]],
				 ""Flags"": [ 772, [ ""UInt32"", {}]],
				 ""CreateReported"": [ 772, [ ""BitField"", { ""end_bit"": 1, ""start_bit"": 0, ""target"": ""UInt32"" }]],
				 ""NoDebugInherit"": [ 772, [ ""BitField"", { ""end_bit"": 2, ""start_bit"": 1, ""target"": ""UInt32"" }]],
				 ""ProcessExiting"": [ 772, [ ""BitField"", { ""end_bit"": 3, ""start_bit"": 2, ""target"": ""UInt32"" }]],
				 ""ProcessDelete"": [ 772, [ ""BitField"", { ""end_bit"": 4, ""start_bit"": 3, ""target"": ""UInt32"" }]],
				 ""ControlFlowGuardEnabled"": [ 772, [ ""BitField"", { ""end_bit"": 5, ""start_bit"": 4, ""target"": ""UInt32"" }]],
				 ""VmDeleted"": [ 772, [ ""BitField"", { ""end_bit"": 6, ""start_bit"": 5, ""target"": ""UInt32"" }]],
				 ""OutswapEnabled"": [ 772, [ ""BitField"", { ""end_bit"": 7, ""start_bit"": 6, ""target"": ""UInt32"" }]],
				 ""Outswapped"": [ 772, [ ""BitField"", { ""end_bit"": 8, ""start_bit"": 7, ""target"": ""UInt32"" }]],
				 ""FailFastOnCommitFail"": [ 772, [ ""BitField"", { ""end_bit"": 9, ""start_bit"": 8, ""target"": ""UInt32"" }]],
				 ""Wow64VaSpace4Gb"": [ 772, [ ""BitField"", { ""end_bit"": 10, ""start_bit"": 9, ""target"": ""UInt32"" }]],
				 ""AddressSpaceInitialized"": [ 772, [ ""BitField"", { ""end_bit"": 12, ""start_bit"": 10, ""target"": ""UInt32"" }]],
				 ""SetTimerResolution"": [ 772, [ ""BitField"", { ""end_bit"": 13, ""start_bit"": 12, ""target"": ""UInt32"" }]],
				 ""BreakOnTermination"": [ 772, [ ""BitField"", { ""end_bit"": 14, ""start_bit"": 13, ""target"": ""UInt32"" }]],
				 ""DeprioritizeViews"": [ 772, [ ""BitField"", { ""end_bit"": 15, ""start_bit"": 14, ""target"": ""UInt32"" }]],
				 ""WriteWatch"": [ 772, [ ""BitField"", { ""end_bit"": 16, ""start_bit"": 15, ""target"": ""UInt32"" }]],
				 ""ProcessInSession"": [ 772, [ ""BitField"", { ""end_bit"": 17, ""start_bit"": 16, ""target"": ""UInt32"" }]],
				 ""OverrideAddressSpace"": [ 772, [ ""BitField"", { ""end_bit"": 18, ""start_bit"": 17, ""target"": ""UInt32"" }]],
				 ""HasAddressSpace"": [ 772, [ ""BitField"", { ""end_bit"": 19, ""start_bit"": 18, ""target"": ""UInt32"" }]],
				 ""LaunchPrefetched"": [ 772, [ ""BitField"", { ""end_bit"": 20, ""start_bit"": 19, ""target"": ""UInt32"" }]],
				 ""Background"": [ 772, [ ""BitField"", { ""end_bit"": 21, ""start_bit"": 20, ""target"": ""UInt32"" }]],
				 ""VmTopDown"": [ 772, [ ""BitField"", { ""end_bit"": 22, ""start_bit"": 21, ""target"": ""UInt32"" }]],
				 ""ImageNotifyDone"": [ 772, [ ""BitField"", { ""end_bit"": 23, ""start_bit"": 22, ""target"": ""UInt32"" }]],
				 ""PdeUpdateNeeded"": [ 772, [ ""BitField"", { ""end_bit"": 24, ""start_bit"": 23, ""target"": ""UInt32"" }]],
				 ""VdmAllowed"": [ 772, [ ""BitField"", { ""end_bit"": 25, ""start_bit"": 24, ""target"": ""UInt32"" }]],
				 ""ProcessRundown"": [ 772, [ ""BitField"", { ""end_bit"": 26, ""start_bit"": 25, ""target"": ""UInt32"" }]],
				 ""ProcessInserted"": [ 772, [ ""BitField"", { ""end_bit"": 27, ""start_bit"": 26, ""target"": ""UInt32"" }]],
				 ""DefaultIoPriority"": [ 772, [ ""BitField"", { ""end_bit"": 30, ""start_bit"": 27, ""target"": ""UInt32"" }]],
				 ""ProcessSelfDelete"": [ 772, [ ""BitField"", { ""end_bit"": 31, ""start_bit"": 30, ""target"": ""UInt32"" }]],
				 ""SetTimerResolutionLink"": [ 772, [ ""BitField"", { ""end_bit"": 32, ""start_bit"": 31, ""target"": ""UInt32"" }]],
				 ""CreateTime"": [ 776, [ ""_LARGE_INTEGER"", {}]],
				 ""ProcessQuotaUsage"": [ 784, [ ""UInt64[2]"", {}]],
				 ""ProcessQuotaPeak"": [ 800, [ ""UInt64[2]"", {}]],
				 ""PeakVirtualSize"": [ 816, [ ""UInt64"", {}]],
				 ""VirtualSize"": [ 824, [ ""UInt64"", {}]],
				 ""SessionProcessLinks"": [ 832, [ ""_LIST_ENTRY"", {}]],
				 ""ExceptionPortData"": [ 848, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""ExceptionPortValue"": [ 848, [ ""UInt64"", {}]],
				 ""ExceptionPortState"": [ 848, [ ""BitField"", { ""end_bit"": 3, ""start_bit"": 0, ""target"": ""UInt64"" }]],
				 ""Token"": [ 856, [ ""_EX_FAST_REF"", {}]],
				 ""WorkingSetPage"": [ 864, [ ""UInt64"", {}]],
				 ""AddressCreationLock"": [ 872, [ ""_EX_PUSH_LOCK"", {}]],
				 ""PageTableCommitmentLock"": [ 880, [ ""_EX_PUSH_LOCK"", {}]],
				 ""RotateInProgress"": [ 888, [ ""Pointer"", { ""target"": ""_ETHREAD"" }]],
				 ""ForkInProgress"": [ 896, [ ""Pointer"", { ""target"": ""_ETHREAD"" }]],
				 ""CommitChargeJob"": [ 904, [ ""Pointer"", { ""target"": ""_EJOB"" }]],
				 ""CloneRoot"": [ 912, [ ""_RTL_AVL_TREE"", {}]],
				 ""NumberOfPrivatePages"": [ 920, [ ""UInt64"", {}]],
				 ""NumberOfLockedPages"": [ 928, [ ""UInt64"", {}]],
				 ""Win32Process"": [ 936, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""Job"": [ 944, [ ""Pointer"", { ""target"": ""_EJOB"" }]],
				 ""SectionObject"": [ 952, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""SectionBaseAddress"": [ 960, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""Cookie"": [ 968, [ ""UInt32"", {}]],
				 ""WorkingSetWatch"": [ 976, [ ""Pointer"", { ""target"": ""_PAGEFAULT_HISTORY"" }]],
				 ""Win32WindowStation"": [ 984, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""InheritedFromUniqueProcessId"": [ 992, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""LdtInformation"": [ 1000, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""OwnerProcessId"": [ 1008, [ ""UInt64"", {}]],
				 ""Peb"": [ 1016, [ ""Pointer"", { ""target"": ""_PEB"" }]],
				 ""Session"": [ 1024, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""AweInfo"": [ 1032, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""QuotaBlock"": [ 1040, [ ""Pointer"", { ""target"": ""_EPROCESS_QUOTA_BLOCK"" }]],
				 ""ObjectTable"": [ 1048, [ ""Pointer"", { ""target"": ""_HANDLE_TABLE"" }]],
				 ""DebugPort"": [ 1056, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""Wow64Process"": [ 1064, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""DeviceMap"": [ 1072, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""EtwDataSource"": [ 1080, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""PageDirectoryPte"": [ 1088, [ ""UInt64"", {}]],
				 ""ImageFileName"": [ 1096, [ ""Byte[15]"", {}]],
				 ""PriorityClass"": [ 1111, [ ""Byte"", {}]],
				 ""SecurityPort"": [ 1112, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""SeAuditProcessCreationInfo"": [ 1120, [ ""_SE_AUDIT_PROCESS_CREATION_INFO"", {}]],
				 ""JobLinks"": [ 1128, [ ""_LIST_ENTRY"", {}]],
				 ""HighestUserAddress"": [ 1144, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""ThreadListHead"": [ 1152, [ ""_LIST_ENTRY"", {}]],
				 ""ActiveThreads"": [ 1168, [ ""UInt32"", {}]],
				 ""ImagePathHash"": [ 1172, [ ""UInt32"", {}]],
				 ""DefaultHardErrorProcessing"": [ 1176, [ ""UInt32"", {}]],
				 ""LastThreadExitStatus"": [ 1180, [ ""Int32"", {}]],
				 ""PrefetchTrace"": [ 1184, [ ""_EX_FAST_REF"", {}]],
				 ""LockedPagesList"": [ 1192, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""ReadOperationCount"": [ 1200, [ ""_LARGE_INTEGER"", {}]],
				 ""WriteOperationCount"": [ 1208, [ ""_LARGE_INTEGER"", {}]],
				 ""OtherOperationCount"": [ 1216, [ ""_LARGE_INTEGER"", {}]],
				 ""ReadTransferCount"": [ 1224, [ ""_LARGE_INTEGER"", {}]],
				 ""WriteTransferCount"": [ 1232, [ ""_LARGE_INTEGER"", {}]],
				 ""OtherTransferCount"": [ 1240, [ ""_LARGE_INTEGER"", {}]],
				 ""CommitChargeLimit"": [ 1248, [ ""UInt64"", {}]],
				 ""CommitCharge"": [ 1256, [ ""UInt64"", {}]],
				 ""CommitChargePeak"": [ 1264, [ ""UInt64"", {}]],
				 ""Vm"": [ 1272, [ ""_MMSUPPORT"", {}]],
				 ""MmProcessLinks"": [ 1520, [ ""_LIST_ENTRY"", {}]],
				 ""ModifiedPageCount"": [ 1536, [ ""UInt32"", {}]],
				 ""ExitStatus"": [ 1540, [ ""Int32"", {}]],
				 ""VadRoot"": [ 1544, [ ""_RTL_AVL_TREE"", {}]],
				 ""VadHint"": [ 1552, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""VadCount"": [ 1560, [ ""UInt64"", {}]],
				 ""VadPhysicalPages"": [ 1568, [ ""UInt64"", {}]],
				 ""VadPhysicalPagesLimit"": [ 1576, [ ""UInt64"", {}]],
				 ""AlpcContext"": [ 1584, [ ""_ALPC_PROCESS_CONTEXT"", {}]],
				 ""TimerResolutionLink"": [ 1616, [ ""_LIST_ENTRY"", {}]],
				 ""TimerResolutionStackRecord"": [ 1632, [ ""Pointer"", { ""target"": ""_PO_DIAG_STACK_RECORD"" }]],
				 ""RequestedTimerResolution"": [ 1640, [ ""UInt32"", {}]],
				 ""SmallestTimerResolution"": [ 1644, [ ""UInt32"", {}]],
				 ""ExitTime"": [ 1648, [ ""_LARGE_INTEGER"", {}]],
				 ""InvertedFunctionTable"": [ 1656, [ ""Pointer"", { ""target"": ""_INVERTED_FUNCTION_TABLE"" }]],
				 ""InvertedFunctionTableLock"": [ 1664, [ ""_EX_PUSH_LOCK"", {}]],
				 ""ActiveThreadsHighWatermark"": [ 1672, [ ""UInt32"", {}]],
				 ""LargePrivateVadCount"": [ 1676, [ ""UInt32"", {}]],
				 ""ThreadListLock"": [ 1680, [ ""_EX_PUSH_LOCK"", {}]],
				 ""WnfContext"": [ 1688, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""Spare0"": [ 1696, [ ""UInt64"", {}]],
				 ""SignatureLevel"": [ 1704, [ ""Byte"", {}]],
				 ""SectionSignatureLevel"": [ 1705, [ ""Byte"", {}]],
				 ""Protection"": [ 1706, [ ""_PS_PROTECTION"", {}]],
				 ""HangCount"": [ 1707, [ ""Byte"", {}]],
				 ""Flags3"": [ 1708, [ ""UInt32"", {}]],
				 ""Minimal"": [ 1708, [ ""BitField"", { ""end_bit"": 1, ""start_bit"": 0, ""target"": ""UInt32"" }]],
				 ""ReplacingPageRoot"": [ 1708, [ ""BitField"", { ""end_bit"": 2, ""start_bit"": 1, ""target"": ""UInt32"" }]],
				 ""DisableNonSystemFonts"": [ 1708, [ ""BitField"", { ""end_bit"": 3, ""start_bit"": 2, ""target"": ""UInt32"" }]],
				 ""AuditNonSystemFontLoading"": [ 1708, [ ""BitField"", { ""end_bit"": 4, ""start_bit"": 3, ""target"": ""UInt32"" }]],
				 ""Crashed"": [ 1708, [ ""BitField"", { ""end_bit"": 5, ""start_bit"": 4, ""target"": ""UInt32"" }]],
				 ""JobVadsAreTracked"": [ 1708, [ ""BitField"", { ""end_bit"": 6, ""start_bit"": 5, ""target"": ""UInt32"" }]],
				 ""VadTrackingDisabled"": [ 1708, [ ""BitField"", { ""end_bit"": 7, ""start_bit"": 6, ""target"": ""UInt32"" }]],
				 ""AuxiliaryProcess"": [ 1708, [ ""BitField"", { ""end_bit"": 8, ""start_bit"": 7, ""target"": ""UInt32"" }]],
				 ""SubsystemProcess"": [ 1708, [ ""BitField"", { ""end_bit"": 9, ""start_bit"": 8, ""target"": ""UInt32"" }]],
				 ""IndirectCpuSets"": [ 1708, [ ""BitField"", { ""end_bit"": 10, ""start_bit"": 9, ""target"": ""UInt32"" }]],
				 ""InPrivate"": [ 1708, [ ""BitField"", { ""end_bit"": 11, ""start_bit"": 10, ""target"": ""UInt32"" }]],
				 ""DeviceAsid"": [ 1712, [ ""Int32"", {}]],
				 ""SvmData"": [ 1720, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""SvmProcessLock"": [ 1728, [ ""_EX_PUSH_LOCK"", {}]],
				 ""SvmLock"": [ 1736, [ ""UInt64"", {}]],
				 ""SvmProcessDeviceListHead"": [ 1744, [ ""_LIST_ENTRY"", {}]],
				 ""LastFreezeInterruptTime"": [ 1760, [ ""UInt64"", {}]],
				 ""DiskCounters"": [ 1768, [ ""Pointer"", { ""target"": ""_PROCESS_DISK_COUNTERS"" }]],
				 ""PicoContext"": [ 1776, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""TrustletIdentity"": [ 1784, [ ""UInt64"", {}]],
				 ""KeepAliveCounter"": [ 1792, [ ""UInt32"", {}]],
				 ""NoWakeKeepAliveCounter"": [ 1796, [ ""UInt32"", {}]],
				 ""HighPriorityFaultsAllowed"": [ 1800, [ ""UInt32"", {}]],
				 ""EnergyValues"": [ 1808, [ ""Pointer"", { ""target"": ""_PROCESS_ENERGY_VALUES"" }]],
				 ""VmContext"": [ 1816, [ ""Pointer"", { ""target"": ""void"" }]],
				 ""Silo"": [ 1824, [ ""Pointer"", { ""target"": ""_ESILO"" }]],
				 ""SiloEntry"": [ 1832, [ ""_LIST_ENTRY"", {}]],
				 ""SequenceNumber"": [ 1848, [ ""UInt64"", {}]],
				 ""CreateInterruptTime"": [ 1856, [ ""UInt64"", {}]],
				 ""CreateUnbiasedInterruptTime"": [ 1864, [ ""UInt64"", {}]],
				 ""TotalUnbiasedFrozenTime"": [ 1872, [ ""UInt64"", {}]],
				 ""LastAppStateUpdateTime"": [ 1880, [ ""UInt64"", {}]],
				 ""LastAppStateUptime"": [ 1888, [ ""BitField"", { ""end_bit"": 61, ""start_bit"": 0, ""target"": ""UInt64"" }]],
				 ""LastAppState"": [ 1888, [ ""BitField"", { ""end_bit"": 64, ""start_bit"": 61, ""target"": ""UInt64"" }]],
				 ""SharedCommitCharge"": [ 1896, [ ""UInt64"", {}]],
				 ""SharedCommitLock"": [ 1904, [ ""_EX_PUSH_LOCK"", {}]],
				 ""SharedCommitLinks"": [ 1912, [ ""_LIST_ENTRY"", {}]],
				 ""AllowedCpuSets"": [ 1928, [ ""UInt64"", {}]],
				 ""DefaultCpuSets"": [ 1936, [ ""UInt64"", {}]],
				 ""AllowedCpuSetsIndirect"": [ 1928, [ ""Pointer"", { ""target"": ""UInt64"" }]],
				 ""DefaultCpuSetsIndirect"": [ 1936, [ ""Pointer"", { ""target"": ""UInt64"" }]] }]
				 }
				)";
			}
		}
		public _KPROCESS Pcb
		{
			get
			{
				_KPROCESS returnValue = new _KPROCESS(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public _EX_PUSH_LOCK ProcessLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 728);
				return returnValue;
			}
		}
		public _EX_RUNDOWN_REF RundownProtect
		{
			get
			{
				_EX_RUNDOWN_REF returnValue = new _EX_RUNDOWN_REF(_StructureData, _BufferOffset + 736);
				return returnValue;
			}
		}
		public UInt64 UniqueProcessId{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 744); } }
		public _LIST_ENTRY ActiveProcessLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 752);
				return returnValue;
			}
		}
		public UInt32 Flags2{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 768); } }
		public UInt32 JobNotReallyActive
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 AccountingFolded
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 2) >> 1;
				return (UInt32)value2;
			}
		}
		public UInt32 NewProcessReported
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 4) >> 2;
				return (UInt32)value2;
			}
		}
		public UInt32 ExitProcessReported
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 8) >> 3;
				return (UInt32)value2;
			}
		}
		public UInt32 ReportCommitChanges
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 16) >> 4;
				return (UInt32)value2;
			}
		}
		public UInt32 LastReportMemory
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 32) >> 5;
				return (UInt32)value2;
			}
		}
		public UInt32 ForceWakeCharge
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 64) >> 6;
				return (UInt32)value2;
			}
		}
		public UInt32 CrossSessionCreate
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 128) >> 7;
				return (UInt32)value2;
			}
		}
		public UInt32 NeedsHandleRundown
		{
			get
			{
				// start: 8  end: 9  Mask: 0000000100000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 256) >> 8;
				return (UInt32)value2;
			}
		}
		public UInt32 RefTraceEnabled
		{
			get
			{
				// start: 9  end: 10  Mask: 0000001000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 512) >> 9;
				return (UInt32)value2;
			}
		}
		public UInt32 DisableDynamicCode
		{
			get
			{
				// start: 10  end: 11  Mask: 0000010000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 1024) >> 10;
				return (UInt32)value2;
			}
		}
		public UInt32 EmptyJobEvaluated
		{
			get
			{
				// start: 11  end: 12  Mask: 0000100000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 2048) >> 11;
				return (UInt32)value2;
			}
		}
		public UInt32 DefaultPagePriority
		{
			get
			{
				// start: 12  end: 15  Mask: 0111000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 28672) >> 12;
				return (UInt32)value2;
			}
		}
		public UInt32 PrimaryTokenFrozen
		{
			get
			{
				// start: 15  end: 16  Mask: 1000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 32768) >> 15;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessVerifierTarget
		{
			get
			{
				// start: 16  end: 17  Mask: 10000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 65536) >> 16;
				return (UInt32)value2;
			}
		}
		public UInt32 StackRandomizationDisabled
		{
			get
			{
				// start: 17  end: 18  Mask: 100000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 131072) >> 17;
				return (UInt32)value2;
			}
		}
		public UInt32 AffinityPermanent
		{
			get
			{
				// start: 18  end: 19  Mask: 1000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 262144) >> 18;
				return (UInt32)value2;
			}
		}
		public UInt32 AffinityUpdateEnable
		{
			get
			{
				// start: 19  end: 20  Mask: 10000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 524288) >> 19;
				return (UInt32)value2;
			}
		}
		public UInt32 PropagateNode
		{
			get
			{
				// start: 20  end: 21  Mask: 100000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 1048576) >> 20;
				return (UInt32)value2;
			}
		}
		public UInt32 ExplicitAffinity
		{
			get
			{
				// start: 21  end: 22  Mask: 1000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 2097152) >> 21;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessExecutionState
		{
			get
			{
				// start: 22  end: 24  Mask: 110000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 12582912) >> 22;
				return (UInt32)value2;
			}
		}
		public UInt32 DisallowStrippedImages
		{
			get
			{
				// start: 24  end: 25  Mask: 1000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 16777216) >> 24;
				return (UInt32)value2;
			}
		}
		public UInt32 HighEntropyASLREnabled
		{
			get
			{
				// start: 25  end: 26  Mask: 10000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 33554432) >> 25;
				return (UInt32)value2;
			}
		}
		public UInt32 ExtensionPointDisable
		{
			get
			{
				// start: 26  end: 27  Mask: 100000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 67108864) >> 26;
				return (UInt32)value2;
			}
		}
		public UInt32 ForceRelocateImages
		{
			get
			{
				// start: 27  end: 28  Mask: 1000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 134217728) >> 27;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessStateChangeRequest
		{
			get
			{
				// start: 28  end: 30  Mask: 110000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 805306368) >> 28;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessStateChangeInProgress
		{
			get
			{
				// start: 30  end: 31  Mask: 1000000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 1073741824) >> 30;
				return (UInt32)value2;
			}
		}
		public UInt32 DisallowWin32kSystemCalls
		{
			get
			{
				// start: 31  end: 32  Mask: 10000000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 768);
				var value2 = (value & 2147483648) >> 31;
				return (UInt32)value2;
			}
		}
		public UInt32 Flags{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 772); } }
		public UInt32 CreateReported
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 NoDebugInherit
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 2) >> 1;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessExiting
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 4) >> 2;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessDelete
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 8) >> 3;
				return (UInt32)value2;
			}
		}
		public UInt32 ControlFlowGuardEnabled
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 16) >> 4;
				return (UInt32)value2;
			}
		}
		public UInt32 VmDeleted
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 32) >> 5;
				return (UInt32)value2;
			}
		}
		public UInt32 OutswapEnabled
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 64) >> 6;
				return (UInt32)value2;
			}
		}
		public UInt32 Outswapped
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 128) >> 7;
				return (UInt32)value2;
			}
		}
		public UInt32 FailFastOnCommitFail
		{
			get
			{
				// start: 8  end: 9  Mask: 0000000100000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 256) >> 8;
				return (UInt32)value2;
			}
		}
		public UInt32 Wow64VaSpace4Gb
		{
			get
			{
				// start: 9  end: 10  Mask: 0000001000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 512) >> 9;
				return (UInt32)value2;
			}
		}
		public UInt32 AddressSpaceInitialized
		{
			get
			{
				// start: 10  end: 12  Mask: 0000110000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 3072) >> 10;
				return (UInt32)value2;
			}
		}
		public UInt32 SetTimerResolution
		{
			get
			{
				// start: 12  end: 13  Mask: 0001000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 4096) >> 12;
				return (UInt32)value2;
			}
		}
		public UInt32 BreakOnTermination
		{
			get
			{
				// start: 13  end: 14  Mask: 0010000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 8192) >> 13;
				return (UInt32)value2;
			}
		}
		public UInt32 DeprioritizeViews
		{
			get
			{
				// start: 14  end: 15  Mask: 0100000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 16384) >> 14;
				return (UInt32)value2;
			}
		}
		public UInt32 WriteWatch
		{
			get
			{
				// start: 15  end: 16  Mask: 1000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 32768) >> 15;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessInSession
		{
			get
			{
				// start: 16  end: 17  Mask: 10000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 65536) >> 16;
				return (UInt32)value2;
			}
		}
		public UInt32 OverrideAddressSpace
		{
			get
			{
				// start: 17  end: 18  Mask: 100000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 131072) >> 17;
				return (UInt32)value2;
			}
		}
		public UInt32 HasAddressSpace
		{
			get
			{
				// start: 18  end: 19  Mask: 1000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 262144) >> 18;
				return (UInt32)value2;
			}
		}
		public UInt32 LaunchPrefetched
		{
			get
			{
				// start: 19  end: 20  Mask: 10000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 524288) >> 19;
				return (UInt32)value2;
			}
		}
		public UInt32 Background
		{
			get
			{
				// start: 20  end: 21  Mask: 100000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 1048576) >> 20;
				return (UInt32)value2;
			}
		}
		public UInt32 VmTopDown
		{
			get
			{
				// start: 21  end: 22  Mask: 1000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 2097152) >> 21;
				return (UInt32)value2;
			}
		}
		public UInt32 ImageNotifyDone
		{
			get
			{
				// start: 22  end: 23  Mask: 10000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 4194304) >> 22;
				return (UInt32)value2;
			}
		}
		public UInt32 PdeUpdateNeeded
		{
			get
			{
				// start: 23  end: 24  Mask: 100000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 8388608) >> 23;
				return (UInt32)value2;
			}
		}
		public UInt32 VdmAllowed
		{
			get
			{
				// start: 24  end: 25  Mask: 1000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 16777216) >> 24;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessRundown
		{
			get
			{
				// start: 25  end: 26  Mask: 10000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 33554432) >> 25;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessInserted
		{
			get
			{
				// start: 26  end: 27  Mask: 100000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 67108864) >> 26;
				return (UInt32)value2;
			}
		}
		public UInt32 DefaultIoPriority
		{
			get
			{
				// start: 27  end: 30  Mask: 111000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 939524096) >> 27;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessSelfDelete
		{
			get
			{
				// start: 30  end: 31  Mask: 1000000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 1073741824) >> 30;
				return (UInt32)value2;
			}
		}
		public UInt32 SetTimerResolutionLink
		{
			get
			{
				// start: 31  end: 32  Mask: 10000000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 772);
				var value2 = (value & 2147483648) >> 31;
				return (UInt32)value2;
			}
		}
		public _LARGE_INTEGER CreateTime
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 776);
				return returnValue;
			}
		}
		public UInt64[2] ProcessQuotaUsage{ get { return BitConverter.ToUInt64[2](_StructureData, _BufferOffset + 784); } }
		public UInt64[2] ProcessQuotaPeak{ get { return BitConverter.ToUInt64[2](_StructureData, _BufferOffset + 800); } }
		public UInt64 PeakVirtualSize{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 816); } }
		public UInt64 VirtualSize{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 824); } }
		public _LIST_ENTRY SessionProcessLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 832);
				return returnValue;
			}
		}
		public UInt64 ExceptionPortData{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 848); } }
		public UInt64 ExceptionPortValue{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 848); } }
		public UInt64 ExceptionPortState
		{
			get
			{
				// start: 0  end: 3  Mask: 0000000000000111
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 848);
				var value2 = (value & 7) >> 0;
				return (UInt64)value2;
			}
		}
		public _EX_FAST_REF Token
		{
			get
			{
				_EX_FAST_REF returnValue = new _EX_FAST_REF(_StructureData, _BufferOffset + 856);
				return returnValue;
			}
		}
		public UInt64 WorkingSetPage{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 864); } }
		public _EX_PUSH_LOCK AddressCreationLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 872);
				return returnValue;
			}
		}
		public _EX_PUSH_LOCK PageTableCommitmentLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 880);
				return returnValue;
			}
		}
		public UInt64 RotateInProgress{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 888); } }
		public UInt64 ForkInProgress{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 896); } }
		public UInt64 CommitChargeJob{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 904); } }
		public _RTL_AVL_TREE CloneRoot
		{
			get
			{
				_RTL_AVL_TREE returnValue = new _RTL_AVL_TREE(_StructureData, _BufferOffset + 912);
				return returnValue;
			}
		}
		public UInt64 NumberOfPrivatePages{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 920); } }
		public UInt64 NumberOfLockedPages{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 928); } }
		public UInt64 Win32Process{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 936); } }
		public UInt64 Job{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 944); } }
		public UInt64 SectionObject{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 952); } }
		public UInt64 SectionBaseAddress{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 960); } }
		public UInt32 Cookie{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 968); } }
		public UInt64 WorkingSetWatch{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 976); } }
		public UInt64 Win32WindowStation{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 984); } }
		public UInt64 InheritedFromUniqueProcessId{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 992); } }
		public UInt64 LdtInformation{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1000); } }
		public UInt64 OwnerProcessId{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1008); } }
		public UInt64 Peb{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1016); } }
		public UInt64 Session{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1024); } }
		public UInt64 AweInfo{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1032); } }
		public UInt64 QuotaBlock{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1040); } }
		public UInt64 ObjectTable{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1048); } }
		public UInt64 DebugPort{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1056); } }
		public UInt64 Wow64Process{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1064); } }
		public UInt64 DeviceMap{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1072); } }
		public UInt64 EtwDataSource{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1080); } }
		public UInt64 PageDirectoryPte{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1088); } }
		public Byte[15] ImageFileName{ get { return BitConverter.ToByte[15](_StructureData, _BufferOffset + 1096); } }
		public Byte PriorityClass{ get { return _StructureData[_BufferOffset +1111]; } }
		public UInt64 SecurityPort{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1112); } }
		public _SE_AUDIT_PROCESS_CREATION_INFO SeAuditProcessCreationInfo
		{
			get
			{
				_SE_AUDIT_PROCESS_CREATION_INFO returnValue = new _SE_AUDIT_PROCESS_CREATION_INFO(_StructureData, _BufferOffset + 1120);
				return returnValue;
			}
		}
		public _LIST_ENTRY JobLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 1128);
				return returnValue;
			}
		}
		public UInt64 HighestUserAddress{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1144); } }
		public _LIST_ENTRY ThreadListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 1152);
				return returnValue;
			}
		}
		public UInt32 ActiveThreads{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1168); } }
		public UInt32 ImagePathHash{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1172); } }
		public UInt32 DefaultHardErrorProcessing{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1176); } }
		public Int32 LastThreadExitStatus{ get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 1180); } }
		public _EX_FAST_REF PrefetchTrace
		{
			get
			{
				_EX_FAST_REF returnValue = new _EX_FAST_REF(_StructureData, _BufferOffset + 1184);
				return returnValue;
			}
		}
		public UInt64 LockedPagesList{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1192); } }
		public _LARGE_INTEGER ReadOperationCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1200);
				return returnValue;
			}
		}
		public _LARGE_INTEGER WriteOperationCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1208);
				return returnValue;
			}
		}
		public _LARGE_INTEGER OtherOperationCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1216);
				return returnValue;
			}
		}
		public _LARGE_INTEGER ReadTransferCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1224);
				return returnValue;
			}
		}
		public _LARGE_INTEGER WriteTransferCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1232);
				return returnValue;
			}
		}
		public _LARGE_INTEGER OtherTransferCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1240);
				return returnValue;
			}
		}
		public UInt64 CommitChargeLimit{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1248); } }
		public UInt64 CommitCharge{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1256); } }
		public UInt64 CommitChargePeak{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1264); } }
		public _MMSUPPORT Vm
		{
			get
			{
				_MMSUPPORT returnValue = new _MMSUPPORT(_StructureData, _BufferOffset + 1272);
				return returnValue;
			}
		}
		public _LIST_ENTRY MmProcessLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 1520);
				return returnValue;
			}
		}
		public UInt32 ModifiedPageCount{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1536); } }
		public Int32 ExitStatus{ get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 1540); } }
		public _RTL_AVL_TREE VadRoot
		{
			get
			{
				_RTL_AVL_TREE returnValue = new _RTL_AVL_TREE(_StructureData, _BufferOffset + 1544);
				return returnValue;
			}
		}
		public UInt64 VadHint{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1552); } }
		public UInt64 VadCount{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1560); } }
		public UInt64 VadPhysicalPages{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1568); } }
		public UInt64 VadPhysicalPagesLimit{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1576); } }
		public _ALPC_PROCESS_CONTEXT AlpcContext
		{
			get
			{
				_ALPC_PROCESS_CONTEXT returnValue = new _ALPC_PROCESS_CONTEXT(_StructureData, _BufferOffset + 1584);
				return returnValue;
			}
		}
		public _LIST_ENTRY TimerResolutionLink
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 1616);
				return returnValue;
			}
		}
		public UInt64 TimerResolutionStackRecord{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1632); } }
		public UInt32 RequestedTimerResolution{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1640); } }
		public UInt32 SmallestTimerResolution{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1644); } }
		public _LARGE_INTEGER ExitTime
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1648);
				return returnValue;
			}
		}
		public UInt64 InvertedFunctionTable{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1656); } }
		public _EX_PUSH_LOCK InvertedFunctionTableLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 1664);
				return returnValue;
			}
		}
		public UInt32 ActiveThreadsHighWatermark{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1672); } }
		public UInt32 LargePrivateVadCount{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1676); } }
		public _EX_PUSH_LOCK ThreadListLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 1680);
				return returnValue;
			}
		}
		public UInt64 WnfContext{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1688); } }
		public UInt64 Spare0{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1696); } }
		public Byte SignatureLevel{ get { return _StructureData[_BufferOffset +1704]; } }
		public Byte SectionSignatureLevel{ get { return _StructureData[_BufferOffset +1705]; } }
		public _PS_PROTECTION Protection
		{
			get
			{
				_PS_PROTECTION returnValue = new _PS_PROTECTION(_StructureData, _BufferOffset + 1706);
				return returnValue;
			}
		}
		public Byte HangCount{ get { return _StructureData[_BufferOffset +1707]; } }
		public UInt32 Flags3{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708); } }
		public UInt32 Minimal
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 ReplacingPageRoot
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708);
				var value2 = (value & 2) >> 1;
				return (UInt32)value2;
			}
		}
		public UInt32 DisableNonSystemFonts
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708);
				var value2 = (value & 4) >> 2;
				return (UInt32)value2;
			}
		}
		public UInt32 AuditNonSystemFontLoading
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708);
				var value2 = (value & 8) >> 3;
				return (UInt32)value2;
			}
		}
		public UInt32 Crashed
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708);
				var value2 = (value & 16) >> 4;
				return (UInt32)value2;
			}
		}
		public UInt32 JobVadsAreTracked
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708);
				var value2 = (value & 32) >> 5;
				return (UInt32)value2;
			}
		}
		public UInt32 VadTrackingDisabled
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708);
				var value2 = (value & 64) >> 6;
				return (UInt32)value2;
			}
		}
		public UInt32 AuxiliaryProcess
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708);
				var value2 = (value & 128) >> 7;
				return (UInt32)value2;
			}
		}
		public UInt32 SubsystemProcess
		{
			get
			{
				// start: 8  end: 9  Mask: 0000000100000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708);
				var value2 = (value & 256) >> 8;
				return (UInt32)value2;
			}
		}
		public UInt32 IndirectCpuSets
		{
			get
			{
				// start: 9  end: 10  Mask: 0000001000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708);
				var value2 = (value & 512) >> 9;
				return (UInt32)value2;
			}
		}
		public UInt32 InPrivate
		{
			get
			{
				// start: 10  end: 11  Mask: 0000010000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1708);
				var value2 = (value & 1024) >> 10;
				return (UInt32)value2;
			}
		}
		public Int32 DeviceAsid{ get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 1712); } }
		public UInt64 SvmData{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1720); } }
		public _EX_PUSH_LOCK SvmProcessLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 1728);
				return returnValue;
			}
		}
		public UInt64 SvmLock{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1736); } }
		public _LIST_ENTRY SvmProcessDeviceListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 1744);
				return returnValue;
			}
		}
		public UInt64 LastFreezeInterruptTime{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1760); } }
		public UInt64 DiskCounters{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1768); } }
		public UInt64 PicoContext{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1776); } }
		public UInt64 TrustletIdentity{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1784); } }
		public UInt32 KeepAliveCounter{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1792); } }
		public UInt32 NoWakeKeepAliveCounter{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1796); } }
		public UInt32 HighPriorityFaultsAllowed{ get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1800); } }
		public UInt64 EnergyValues{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1808); } }
		public UInt64 VmContext{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1816); } }
		public UInt64 Silo{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1824); } }
		public _LIST_ENTRY SiloEntry
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 1832);
				return returnValue;
			}
		}
		public UInt64 SequenceNumber{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1848); } }
		public UInt64 CreateInterruptTime{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1856); } }
		public UInt64 CreateUnbiasedInterruptTime{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1864); } }
		public UInt64 TotalUnbiasedFrozenTime{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1872); } }
		public UInt64 LastAppStateUpdateTime{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1880); } }
		public UInt64 LastAppStateUptime
		{
			get
			{
				// start: 0  end: 61  Mask: 0000000000000000000000000000011111111111111111111111111111111
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 1888);
				var value2 = (value & 4294967295) >> 0;
				return (UInt64)value2;
			}
		}
		public UInt64 LastAppState
		{
			get
			{
				// start: 61  end: 64  Mask: 0000000000000000000000000000000000000000000000000000000000000000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 1888);
				var value2 = (value & 0) >> 61;
				return (UInt64)value2;
			}
		}
		public UInt64 SharedCommitCharge{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1896); } }
		public _EX_PUSH_LOCK SharedCommitLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 1904);
				return returnValue;
			}
		}
		public _LIST_ENTRY SharedCommitLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 1912);
				return returnValue;
			}
		}
		public UInt64 AllowedCpuSets{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1928); } }
		public UInt64 DefaultCpuSets{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1936); } }
		public UInt64 AllowedCpuSetsIndirect{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1928); } }
		public UInt64 DefaultCpuSetsIndirect{ get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1936); } }
	}
	#endregion
}
