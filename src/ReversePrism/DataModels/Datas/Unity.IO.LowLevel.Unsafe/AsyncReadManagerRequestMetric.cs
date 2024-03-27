using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AssetName                                000186672F10 ModelPrimitiveType string string string String
    // 018 FileName                                 000186672F10 ModelPrimitiveType string string string String
    // 020 OffsetBytes                              00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 028 SizeBytes                                00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 030 AssetTypeId                              00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 038 CurrentBytesRead                         00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 040 BatchReadCount                           000186699A20 ModelPrimitiveType uint uint uint UInt32
    // 044 IsBatchRead                              0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 048 State                                    000186525790 ModelEnumType ProcessingState ProcessingState ProcessingState Int32
    // 04C ReadType                                 00018657BE60 ModelEnumType FileReadType FileReadType FileReadType Int32
    // 050 PriorityLevel                            000186515050 ModelEnumType Priority Priority Priority Int32
    // 054 Subsystem                                0001866E7500 ModelEnumType AssetLoadingSubsystem AssetLoadingSubsystem AssetLoadingSubsystem Int32
    // 058 RequestTimeMicroseconds                  0001865C35C0 ModelPrimitiveType double double double Double
    // 060 TimeInQueueMicroseconds                  0001865C35C0 ModelPrimitiveType double double double Double
    // 068 TotalTimeMicroseconds                    0001865C35C0 ModelPrimitiveType double double double Double
    public partial class AsyncReadManagerRequestMetric
    {
        public string                                   AssetName                               { get; set; }
        public string                                   FileName                                { get; set; }
        public ulong                                    OffsetBytes                             { get; set; }
        public ulong                                    SizeBytes                               { get; set; }
        public ulong                                    AssetTypeId                             { get; set; }
        public ulong                                    CurrentBytesRead                        { get; set; }
        public uint                                     BatchReadCount                          { get; set; }
        public bool                                     IsBatchRead                             { get; set; }
        public ProcessingState                          State                                   { get; set; }
        public FileReadType                             ReadType                                { get; set; }
        public Priority                                 PriorityLevel                           { get; set; }
        public AssetLoadingSubsystem                    Subsystem                               { get; set; }
        public double                                   RequestTimeMicroseconds                 { get; set; }
        public double                                   TimeInQueueMicroseconds                 { get; set; }
        public double                                   TotalTimeMicroseconds                   { get; set; }

        public static AsyncReadManagerRequestMetric? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncReadManagerRequestMetric();

            value.AssetName                                 = GetString(new IntPtr(p + 0x010)); // 0270022FB598 0x10 AssetName                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.FileName                                  = GetString(new IntPtr(p + 0x018)); // 0270022FB5B8 0x18 FileName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.OffsetBytes                               = GetUInt64(new IntPtr(p + 0x020)); // 0270022FB5D8 0x20 OffsetBytes                 ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.SizeBytes                                 = GetUInt64(new IntPtr(p + 0x028)); // 0270022FB5F8 0x28 SizeBytes                   ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.AssetTypeId                               = GetUInt64(new IntPtr(p + 0x030)); // 0270022FB618 0x30 AssetTypeId                 ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.CurrentBytesRead                          = GetUInt64(new IntPtr(p + 0x038)); // 0270022FB638 0x38 CurrentBytesRead            ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.BatchReadCount                            = GetUInt32(new IntPtr(p + 0x040)); // 0270022FB658 0x40 BatchReadCount              ( 000186699A20 ModelPrimitiveType uint uint uint UInt32 )
            value.IsBatchRead                               = GetBool(new IntPtr(p + 0x044)); // 0270022FB678 0x44 IsBatchRead                 ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.State                                     = (ProcessingState)GetInt32(new IntPtr(p + 0x048)); // 0270022FB698 0x48 State                       ( 000186525790 ModelEnumType ProcessingState ProcessingState ProcessingState Int32 )
            value.ReadType                                  = (FileReadType)GetInt32(new IntPtr(p + 0x04C)); // 0270022FB6B8 0x4C ReadType                    ( 00018657BE60 ModelEnumType FileReadType FileReadType FileReadType Int32 )
            value.PriorityLevel                             = (Priority)GetInt32(new IntPtr(p + 0x050)); // 0270022FB6D8 0x50 PriorityLevel               ( 000186515050 ModelEnumType Priority Priority Priority Int32 )
            value.Subsystem                                 = (AssetLoadingSubsystem)GetInt32(new IntPtr(p + 0x054)); // 0270022FB6F8 0x54 Subsystem                   ( 0001866E7500 ModelEnumType AssetLoadingSubsystem AssetLoadingSubsystem AssetLoadingSubsystem Int32 )
            value.RequestTimeMicroseconds                   = GetDouble(new IntPtr(p + 0x058)); // 0270022FB718 0x58 RequestTimeMicroseconds     ( 0001865C35C0 ModelPrimitiveType double double double Double )
            value.TimeInQueueMicroseconds                   = GetDouble(new IntPtr(p + 0x060)); // 0270022FB738 0x60 TimeInQueueMicroseconds     ( 0001865C35C0 ModelPrimitiveType double double double Double )
            value.TotalTimeMicroseconds                     = GetDouble(new IntPtr(p + 0x068)); // 0270022FB758 0x68 TotalTimeMicroseconds       ( 0001865C35C0 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
