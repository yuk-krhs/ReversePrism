using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FIsReentrant                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 MyLock                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 NumWriteWaiters                          000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 01C NumReadWaiters                           000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 020 NumWriteUpgradeWaiters                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 024 NumUpgradeWaiters                        000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 028 FNoWaiters                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C UpgradeLockOwnerId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 WriteLockOwnerId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 WriteEvent                               0001865C9D10 ModelClassType EventWaitHandle EventWaitHandle EventWaitHandle Pointer
    // 040 ReadEvent                                0001865C9D10 ModelClassType EventWaitHandle EventWaitHandle EventWaitHandle Pointer
    // 048 UpgradeEvent                             0001865C9D10 ModelClassType EventWaitHandle EventWaitHandle EventWaitHandle Pointer
    // 050 WaitUpgradeEvent                         0001865C9D10 ModelClassType EventWaitHandle EventWaitHandle EventWaitHandle Pointer
    // 000 s_nextLockID                             long IL2CPP_TYPE_I8
    // 058 LockID                                   0001865F7700 ModelPrimitiveType long long long Int64
    // FFFFFFFF t_rwc                                    ReaderWriterCount IL2CPP_TYPE_CLASS
    // 060 FUpgradeThreadHoldingRead                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 064 Owners                                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 068 FDisposed                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ReaderWriterLockSlim
    {
        public bool                                     FIsReentrant                            { get; set; }
        public int                                      MyLock                                  { get; set; }
        public uint                                     NumWriteWaiters                         { get; set; }
        public uint                                     NumReadWaiters                          { get; set; }
        public uint                                     NumWriteUpgradeWaiters                  { get; set; }
        public uint                                     NumUpgradeWaiters                       { get; set; }
        public bool                                     FNoWaiters                              { get; set; }
        public int                                      UpgradeLockOwnerId                      { get; set; }
        public int                                      WriteLockOwnerId                        { get; set; }
        public EventWaitHandle?                         WriteEvent                              { get; set; }
        public EventWaitHandle?                         ReadEvent                               { get; set; }
        public EventWaitHandle?                         UpgradeEvent                            { get; set; }
        public EventWaitHandle?                         WaitUpgradeEvent                        { get; set; }
        public long                                     LockID                                  { get; set; }
        public bool                                     FUpgradeThreadHoldingRead               { get; set; }
        public uint                                     Owners                                  { get; set; }
        public bool                                     FDisposed                               { get; set; }

        public static ReaderWriterLockSlim? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReaderWriterLockSlim();

            value.FIsReentrant                              = GetBool(new IntPtr(p + 0x010)); // 0270D88FD890 0x10 FIsReentrant                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MyLock                                    = GetInt32(new IntPtr(p + 0x014)); // 0270D88FD8B0 0x14 MyLock                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NumWriteWaiters                           = GetUInt32(new IntPtr(p + 0x018)); // 0270D88FD8D0 0x18 NumWriteWaiters             ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.NumReadWaiters                            = GetUInt32(new IntPtr(p + 0x01C)); // 0270D88FD8F0 0x1C NumReadWaiters              ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.NumWriteUpgradeWaiters                    = GetUInt32(new IntPtr(p + 0x020)); // 0270D88FD910 0x20 NumWriteUpgradeWaiters      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.NumUpgradeWaiters                         = GetUInt32(new IntPtr(p + 0x024)); // 0270D88FD930 0x24 NumUpgradeWaiters           ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.FNoWaiters                                = GetBool(new IntPtr(p + 0x028)); // 0270D88FD950 0x28 FNoWaiters                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UpgradeLockOwnerId                        = GetInt32(new IntPtr(p + 0x02C)); // 0270D88FD970 0x2C UpgradeLockOwnerId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WriteLockOwnerId                          = GetInt32(new IntPtr(p + 0x030)); // 0270D88FD990 0x30 WriteLockOwnerId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WriteEvent                                = GetObject<EventWaitHandle>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventWaitHandle.FromPointer); // 0270D88FD9B0 0x38 WriteEvent                  ( 0001865C9D10 ModelClassType EventWaitHandle EventWaitHandle EventWaitHandle Pointer )
            value.ReadEvent                                 = GetObject<EventWaitHandle>(new IntPtr(p + 0x040), ReversePrism.DataModels.EventWaitHandle.FromPointer); // 0270D88FD9D0 0x40 ReadEvent                   ( 0001865C9D10 ModelClassType EventWaitHandle EventWaitHandle EventWaitHandle Pointer )
            value.UpgradeEvent                              = GetObject<EventWaitHandle>(new IntPtr(p + 0x048), ReversePrism.DataModels.EventWaitHandle.FromPointer); // 0270D88FD9F0 0x48 UpgradeEvent                ( 0001865C9D10 ModelClassType EventWaitHandle EventWaitHandle EventWaitHandle Pointer )
            value.WaitUpgradeEvent                          = GetObject<EventWaitHandle>(new IntPtr(p + 0x050), ReversePrism.DataModels.EventWaitHandle.FromPointer); // 0270D88FDA10 0x50 WaitUpgradeEvent            ( 0001865C9D10 ModelClassType EventWaitHandle EventWaitHandle EventWaitHandle Pointer )
            value.LockID                                    = GetInt64(new IntPtr(p + 0x058)); // 0270D88FDA50 0x58 LockID                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.FUpgradeThreadHoldingRead                 = GetBool(new IntPtr(p + 0x060)); // 0270D88FDA90 0x60 FUpgradeThreadHoldingRead   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Owners                                    = GetUInt32(new IntPtr(p + 0x064)); // 0270D88FDAB0 0x64 Owners                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.FDisposed                                 = GetBool(new IntPtr(p + 0x068)); // 0270D88FDAD0 0x68 FDisposed                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
