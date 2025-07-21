using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AssetName                                ModelPrimitiveType string string string String
    // 018 FileName                                 ModelPrimitiveType string string string String
    // 020 OffsetBytes                              ModelPrimitiveType ulong ulong ulong UInt64
    // 028 SizeBytes                                ModelPrimitiveType ulong ulong ulong UInt64
    // 030 AssetTypeId                              ModelPrimitiveType ulong ulong ulong UInt64
    // 038 CurrentBytesRead                         ModelPrimitiveType ulong ulong ulong UInt64
    // 040 BatchReadCount                           ModelPrimitiveType uint uint uint UInt32
    // 044 IsBatchRead                              ModelPrimitiveType bool bool bool Bool
    // 048 State                                    ModelEnumType ProcessingState ProcessingState ProcessingState Int32
    // 04C ReadType                                 ModelEnumType FileReadType FileReadType FileReadType Int32
    // 050 PriorityLevel                            ModelEnumType Priority Priority Priority Int32
    // 054 Subsystem                                ModelEnumType AssetLoadingSubsystem AssetLoadingSubsystem AssetLoadingSubsystem Int32
    // 058 RequestTimeMicroseconds                  ModelPrimitiveType double double double Double
    // 060 TimeInQueueMicroseconds                  ModelPrimitiveType double double double Double
    // 068 TotalTimeMicroseconds                    ModelPrimitiveType double double double Double
    public partial class AsyncReadManagerRequestMetric : DataModel
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
            var value   = new AsyncReadManagerRequestMetric() { Pointer= p0 };

            value.AssetName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 AssetName                   ( ModelPrimitiveType string string string String )
            value.FileName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 FileName                    ( ModelPrimitiveType string string string String )
            value.OffsetBytes                               = GetUInt64(new IntPtr(p + 0x020)); // 0x20 OffsetBytes                 ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.SizeBytes                                 = GetUInt64(new IntPtr(p + 0x028)); // 0x28 SizeBytes                   ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.AssetTypeId                               = GetUInt64(new IntPtr(p + 0x030)); // 0x30 AssetTypeId                 ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.CurrentBytesRead                          = GetUInt64(new IntPtr(p + 0x038)); // 0x38 CurrentBytesRead            ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.BatchReadCount                            = GetUInt32(new IntPtr(p + 0x040)); // 0x40 BatchReadCount              ( ModelPrimitiveType uint uint uint UInt32 )
            value.IsBatchRead                               = GetBool(new IntPtr(p + 0x044)); // 0x44 IsBatchRead                 ( ModelPrimitiveType bool bool bool Bool )
            value.State                                     = (ProcessingState)GetInt32(new IntPtr(p + 0x048)); // 0x48 State                       ( ModelEnumType ProcessingState ProcessingState ProcessingState Int32 )
            value.ReadType                                  = (FileReadType)GetInt32(new IntPtr(p + 0x04C)); // 0x4C ReadType                    ( ModelEnumType FileReadType FileReadType FileReadType Int32 )
            value.PriorityLevel                             = (Priority)GetInt32(new IntPtr(p + 0x050)); // 0x50 PriorityLevel               ( ModelEnumType Priority Priority Priority Int32 )
            value.Subsystem                                 = (AssetLoadingSubsystem)GetInt32(new IntPtr(p + 0x054)); // 0x54 Subsystem                   ( ModelEnumType AssetLoadingSubsystem AssetLoadingSubsystem AssetLoadingSubsystem Int32 )
            value.RequestTimeMicroseconds                   = GetDouble(new IntPtr(p + 0x058)); // 0x58 RequestTimeMicroseconds     ( ModelPrimitiveType double double double Double )
            value.TimeInQueueMicroseconds                   = GetDouble(new IntPtr(p + 0x060)); // 0x60 TimeInQueueMicroseconds     ( ModelPrimitiveType double double double Double )
            value.TotalTimeMicroseconds                     = GetDouble(new IntPtr(p + 0x068)); // 0x68 TotalTimeMicroseconds       ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
