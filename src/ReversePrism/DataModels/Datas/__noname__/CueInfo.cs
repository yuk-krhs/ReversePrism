using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Type                                     00018653F780 ModelEnumType CueType CueType CueType Int32
    // 018 Name                                     000186675150 ModelPrimitiveType string string string String
    // 020 UserData                                 000186675150 ModelPrimitiveType string string string String
    // 028 Length                                   0001865F7E40 ModelPrimitiveType long long long Int64
    // 030 Categories                               000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 038 NumLimits                                0001865F1520 ModelPrimitiveType short short short Int16
    // 03A NumBlocks                                000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 03C NumTracks                                000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 03E NumRelatedWaveForms                      000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 040 Priority                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 041 HeaderVisibility                         00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 042 Ignore_player_parameter                  00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 043 Probability                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 044 PanType                                  000186540F20 ModelEnumType PanType PanType PanType Int32
    // 048 Pos3dInfo                                00018653F280 ModelEnumType CuePos3dInfo CuePos3dInfo CuePos3dInfo Int32
    // 090 GameVariableInfo                         0001866D55C0 ModelEnumType GameVariableInfo GameVariableInfo GameVariableInfo Int32
    // 0A0 Volume                                   000186666050 ModelPrimitiveType float float float Single
    public partial class CueInfo : DataModel
    {
        public int                                      Id                                      { get; set; }
        public CueType                                  Type                                    { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   UserData                                { get; set; }
        public long                                     Length                                  { get; set; }
        public List<ushort>?                            Categories                              { get; set; }
        public short                                    NumLimits                               { get; set; }
        public ushort                                   NumBlocks                               { get; set; }
        public ushort                                   NumTracks                               { get; set; }
        public ushort                                   NumRelatedWaveForms                     { get; set; }
        public sbyte                                    Priority                                { get; set; }
        public sbyte                                    HeaderVisibility                        { get; set; }
        public sbyte                                    Ignore_player_parameter                 { get; set; }
        public sbyte                                    Probability                             { get; set; }
        public PanType                                  PanType                                 { get; set; }
        public CuePos3dInfo                             Pos3dInfo                               { get; set; }
        public GameVariableInfo                         GameVariableInfo                        { get; set; }
        public float                                    Volume                                  { get; set; }

        public static CueInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CueInfo() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A729F658 0x10 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Type                                      = (CueType)GetInt32(new IntPtr(p + 0x014)); // 0245A729F678 0x14 Type                        ( 00018653F780 ModelEnumType CueType CueType CueType Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0245A729F698 0x18 Name                        ( 000186675150 ModelPrimitiveType string string string String )
            value.UserData                                  = GetString(new IntPtr(p + 0x020)); // 0245A729F6B8 0x20 UserData                    ( 000186675150 ModelPrimitiveType string string string String )
            value.Length                                    = GetInt64(new IntPtr(p + 0x028)); // 0245A729F6D8 0x28 Length                      ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.Categories                                = GetUInt16List(new IntPtr(p + 0x030)); // 0245A729F6F8 0x30 Categories                  ( 000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.NumLimits                                 = GetInt16(new IntPtr(p + 0x038)); // 0245A729F718 0x38 NumLimits                   ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.NumBlocks                                 = GetUInt16(new IntPtr(p + 0x03A)); // 0245A729F738 0x3A NumBlocks                   ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumTracks                                 = GetUInt16(new IntPtr(p + 0x03C)); // 0245A729F758 0x3C NumTracks                   ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumRelatedWaveForms                       = GetUInt16(new IntPtr(p + 0x03E)); // 0245A729F778 0x3E NumRelatedWaveForms         ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Priority                                  = GetSByte(new IntPtr(p + 0x040)); // 0245A729F798 0x40 Priority                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.HeaderVisibility                          = GetSByte(new IntPtr(p + 0x041)); // 0245A729F7B8 0x41 HeaderVisibility            ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Ignore_player_parameter                   = GetSByte(new IntPtr(p + 0x042)); // 0245A729F7D8 0x42 Ignore_player_parameter     ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Probability                               = GetSByte(new IntPtr(p + 0x043)); // 0245A729F7F8 0x43 Probability                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.PanType                                   = (PanType)GetInt32(new IntPtr(p + 0x044)); // 0245A729F818 0x44 PanType                     ( 000186540F20 ModelEnumType PanType PanType PanType Int32 )
            value.Pos3dInfo                                 = (CuePos3dInfo)GetInt32(new IntPtr(p + 0x048)); // 0245A729F838 0x48 Pos3dInfo                   ( 00018653F280 ModelEnumType CuePos3dInfo CuePos3dInfo CuePos3dInfo Int32 )
            value.GameVariableInfo                          = (GameVariableInfo)GetInt32(new IntPtr(p + 0x090)); // 0245A729F858 0x90 GameVariableInfo            ( 0001866D55C0 ModelEnumType GameVariableInfo GameVariableInfo GameVariableInfo Int32 )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x0A0)); // 0245A729F878 0xA0 Volume                      ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
