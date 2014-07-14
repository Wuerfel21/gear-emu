﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gear.Disassembler
{
    public partial class Spin
    {
        static public readonly Instruction[] Instructions = new Instruction[] {
            new Instruction("FRAME_CALL_RETURN",                  "FrameReturn",        ArguementMode.None),                   //  0x00
            new Instruction("FRAME_CALL_NORETURN",                "FrameNoReturn",      ArguementMode.None),                   //  0x01
            new Instruction("FRAME_CALL_ABORT",                   "FrameAbort",         ArguementMode.None),                   //  0x02
            new Instruction("FRAME_CALL_TRASHABORT",              "FrameTrashAbort",    ArguementMode.None),                   //  0x03
            new Instruction("BRANCH",                             "Branch",             ArguementMode.SignedOffset),           //  0x04
            new Instruction("CALL",                               "Call",               ArguementMode.ByteLiteral),            //  0x05
            new Instruction("OBJCALL",                            "ObjCall",            ArguementMode.ObjCallPair),            //  0x06
            new Instruction("OBJCALL_INDEXED",                    "ObjCall[]",          ArguementMode.ObjCallPair),            //  0x07
            new Instruction("LOOP_START",                         "LoopStart",          ArguementMode.SignedOffset),           //  0x08
            new Instruction("LOOP_CONTINUE",                      "LoopContinue",       ArguementMode.SignedOffset),           //  0x09
            new Instruction("JUMP_IF_FALSE",                      "JumpIfFalse",        ArguementMode.SignedOffset),           //  0x0A
            new Instruction("JUMP_IF_TRUE",                       "JumpIfTrue",         ArguementMode.SignedOffset),           //  0x0B
            new Instruction("JUMP_FROM_STACK",                    "JumpFromStack",      ArguementMode.None),                   //  0x0C
            new Instruction("COMPARE_CASE",                       "Case ==",            ArguementMode.SignedOffset),           //  0x0D
            new Instruction("COMPARE_CASE_RANGE",                 "CaseRange",          ArguementMode.SignedOffset),           //  0x0E
            new Instruction("LOOK_ABORT",                         "LookAbort",          ArguementMode.None),                   //  0x0F
            new Instruction("LOOKUP_COMPARE",                     "LookUpOne",          ArguementMode.None),                   //  0x10
            new Instruction("LOOKDOWN_COMPARE",                   "LookDownOne",        ArguementMode.None),                   //  0x11
            new Instruction("LOOKUPRANGE_COMPARE",                "LookUpRange",        ArguementMode.None),                   //  0x12
            new Instruction("LOOKDOWNRANGE_COMPARE",              "LookDownRange",      ArguementMode.None),                   //  0x13
            new Instruction("QUIT",                               "Quit",               ArguementMode.None),                   //  0x14
            new Instruction("MARK_INTERPRETED",                   "MarkInterpreted",    ArguementMode.None),                   //  0x15
            new Instruction("STRSIZE",                            "StrSize",            ArguementMode.None),                   //  0x16
            new Instruction("STRCOMP",                            "StrComp",            ArguementMode.None),                   //  0x17
            new Instruction("BYTEFILL",                           "ByteFill",           ArguementMode.None),                   //  0x18
            new Instruction("WORDFILL",                           "WordFill",           ArguementMode.None),                   //  0x19
            new Instruction("LONGFILL",                           "LongFill",           ArguementMode.None),                   //  0x1A
            new Instruction("WAITPEQ",                            "WaitPEQ",            ArguementMode.None),                   //  0x1B
            new Instruction("BYTEMOVE",                           "ByteMove",           ArguementMode.None),                   //  0x1C
            new Instruction("WORDMOVE",                           "WordMove",           ArguementMode.None),                   //  0x1D
            new Instruction("LONGMOVE",                           "LongMove",           ArguementMode.None),                   //  0x1E
            new Instruction("WAITPNE",                            "WaitPNE",            ArguementMode.None),                   //  0x1F
            new Instruction("CLKSET",                             "CLKSET",             ArguementMode.None),                   //  0x20
            new Instruction("COGSTOP",                            "CogStop",            ArguementMode.None),                   //  0x21
            new Instruction("LOCKRET",                            "LockRet",            ArguementMode.None),                   //  0x22
            new Instruction("WAITCNT",                            "WaitCNT",            ArguementMode.None),                   //  0x23
            new Instruction("READ_INDEXED_SPR",                   "RdLong SPR[]",       ArguementMode.None),                   //  0x24
            new Instruction("WRITE_INDEXED_SPR",                  "WrLong SPR[]",       ArguementMode.None),                   //  0x25
            new Instruction("EFFECT_INDEXED_SPR",                 "RdWrLong SPR[]",     ArguementMode.Effect),                 //  0x26
            new Instruction("WAITVID",                            "WaitVID",            ArguementMode.None),                   //  0x27
            new Instruction("COGINIT_RETURNS",                    "CogInitReturns",     ArguementMode.None),                   //  0x28
            new Instruction("LOCKNEW_RETURNS",                    "LockNewReturns",     ArguementMode.None),                   //  0x29
            new Instruction("LOCKSET_RETURNS",                    "LockSetReturns",     ArguementMode.None),                   //  0x2A
            new Instruction("LOCKCLR_RETURNS",                    "LockClearReturns",   ArguementMode.None),                   //  0x2B
            new Instruction("COGINIT",                            "CogInit",            ArguementMode.None),                   //  0x2C
            new Instruction("LOCKNEW",                            "LockNew",            ArguementMode.None),                   //  0x2D
            new Instruction("LOCKSET",                            "LockSet",            ArguementMode.None),                   //  0x2E
            new Instruction("LOCKCLR",                            "LockClear",          ArguementMode.None),                   //  0x2F
            new Instruction("ABORT",                              "Abort",              ArguementMode.None),                   //  0x30
            new Instruction("ABORT_WITH_RETURN",                  "AbortWithResult",    ArguementMode.None),                   //  0x31
            new Instruction("RETURN",                             "Return",             ArguementMode.None),                   //  0x32
            new Instruction("POP_RETURN",                         "ReturnWithResult",   ArguementMode.None),                   //  0x33
            new Instruction("PUSH_NEG1",                          "# -1",               ArguementMode.None),                   //  0x34
            new Instruction("PUSH_0",                             "# 0",                ArguementMode.None),                   //  0x35
            new Instruction("PUSH_1",                             "# 1",                ArguementMode.None),                   //  0x36
            new Instruction("PUSH_PACKED_LIT",                    "#",                  ArguementMode.PackedLiteral),          //  0x37
            new Instruction("PUSH_BYTE_LIT",                      "#",                  ArguementMode.ByteLiteral),            //  0x38
            new Instruction("PUSH_WORD_LIT",                      "#",                  ArguementMode.WordLiteral),            //  0x39
            new Instruction("PUSH_MID_LIT",                       "#",                  ArguementMode.NearLongLiteral),        //  0x3A
            new Instruction("PUSH_LONG_LIT",                      "#",                  ArguementMode.LongLiteral),            //  0x3B
            new Instruction("UNKNOWN OP $3C",                     "UNKNOWN OP $3C",     ArguementMode.None),                   //  0x3C
            new Instruction("INDEXED_MEM_OP",                     "MemOP[]",            ArguementMode.MemoryOpCode),           //  0x3D
            new Instruction("INDEXED_RANGE_MEM_OP",               "RangeMemOP[]",       ArguementMode.MemoryOpCode),           //  0x3E
            new Instruction("MEMORY_OP",                          "MEMORY_OP",          ArguementMode.MemoryOpCode),           //  0x3F
            new Instruction("PUSH_VARMEM_LONG_0",                 "Var[0]@",            ArguementMode.None),                   //  0x40
            new Instruction("POP_VARMEM_LONG_0",                  "Var[0]!",            ArguementMode.None),                   //  0x41
            new Instruction("EFFECT_VARMEM_LONG_0",               "Var[0] with",        ArguementMode.Effect),                 //  0x42
            new Instruction("REFERENCE_VARMEM_LONG_0",            "&Var[0]",            ArguementMode.None),                   //  0x43
            new Instruction("PUSH_VARMEM_LONG_1",                 "Var[1]@",            ArguementMode.None),                   //  0x44
            new Instruction("POP_VARMEM_LONG_1",                  "Var[1]!",            ArguementMode.None),                   //  0x45
            new Instruction("EFFECT_VARMEM_LONG_1",               "Var[1] with",        ArguementMode.Effect),                 //  0x46
            new Instruction("REFERENCE_VARMEM_LONG_1",            "&Var[1]",            ArguementMode.None),                   //  0x47
            new Instruction("PUSH_VARMEM_LONG_2",                 "Var[2]@",            ArguementMode.None),                   //  0x48
            new Instruction("POP_VARMEM_LONG_2",                  "Var[2]!",            ArguementMode.None),                   //  0x49
            new Instruction("EFFECT_VARMEM_LONG_2",               "Var[2] with",        ArguementMode.Effect),                 //  0x4A
            new Instruction("REFERENCE_VARMEM_LONG_2",            "&Var[2]",            ArguementMode.None),                   //  0x4B
            new Instruction("PUSH_VARMEM_LONG_3",                 "Var[3]@",            ArguementMode.None),                   //  0x4C
            new Instruction("POP_VARMEM_LONG_3",                  "Var[3]!",            ArguementMode.None),                   //  0x4D
            new Instruction("EFFECT_VARMEM_LONG_3",               "Var[3] with",        ArguementMode.Effect),                 //  0x4E
            new Instruction("REFERENCE_VARMEM_LONG_3",            "&Var[3]",            ArguementMode.None),                   //  0x4F
            new Instruction("PUSH_VARMEM_LONG_4",                 "Var[4]@",            ArguementMode.None),                   //  0x50
            new Instruction("POP_VARMEM_LONG_4",                  "Var[4]!",            ArguementMode.None),                   //  0x51
            new Instruction("EFFECT_VARMEM_LONG_4",               "Var[4] with",        ArguementMode.Effect),                 //  0x52
            new Instruction("REFERENCE_VARMEM_LONG_4",            "&Var[4]",            ArguementMode.None),                   //  0x53
            new Instruction("PUSH_VARMEM_LONG_5",                 "Var[5]@",            ArguementMode.None),                   //  0x54
            new Instruction("POP_VARMEM_LONG_5",                  "Var[5]!",            ArguementMode.None),                   //  0x55
            new Instruction("EFFECT_VARMEM_LONG_5",               "Var[5] with",        ArguementMode.Effect),                 //  0x56
            new Instruction("REFERENCE_VARMEM_LONG_5",            "&Var[5]",            ArguementMode.None),                   //  0x57
            new Instruction("PUSH_VARMEM_LONG_6",                 "Var[6]@",            ArguementMode.None),                   //  0x58
            new Instruction("POP_VARMEM_LONG_6",                  "Var[6]!",            ArguementMode.None),                   //  0x59
            new Instruction("EFFECT_VARMEM_LONG_6",               "Var[6] with",        ArguementMode.Effect),                 //  0x5A
            new Instruction("REFERENCE_VARMEM_LONG_6",            "&Var[6]",            ArguementMode.None),                   //  0x5B
            new Instruction("PUSH_VARMEM_LONG_7",                 "Var[7]@",            ArguementMode.None),                   //  0x5C
            new Instruction("POP_VARMEM_LONG_7",                  "Var[7]!",            ArguementMode.None),                   //  0x5D
            new Instruction("EFFECT_VARMEM_LONG_7",               "Var[7] with",        ArguementMode.Effect),                 //  0x5E
            new Instruction("REFERENCE_VARMEM_LONG_7",            "&Var[7]",            ArguementMode.None),                   //  0x5F
            new Instruction("PUSH_LOCALMEM_LONG_0",               "Loc[0]@",            ArguementMode.None),                   //  0x60
            new Instruction("POP_LOCALMEM_LONG_0",                "Loc[0]!",            ArguementMode.None),                   //  0x61
            new Instruction("EFFECT_LOCALMEM_LONG_0",             "Loc[0] with",        ArguementMode.Effect),                 //  0x62
            new Instruction("REFERENCE_LOCALMEM_LONG_0",          "&Loc[0]",            ArguementMode.None),                   //  0x63
            new Instruction("PUSH_LOCALMEM_LONG_1",               "Loc[1]@",            ArguementMode.None),                   //  0x64
            new Instruction("POP_LOCALMEM_LONG_1",                "Loc[1]!",            ArguementMode.None),                   //  0x65
            new Instruction("EFFECT_LOCALMEM_LONG_1",             "Loc[1] with",        ArguementMode.Effect),                 //  0x66
            new Instruction("REFERENCE_LOCALMEM_LONG_1",          "&Loc[1]",            ArguementMode.None),                   //  0x67
            new Instruction("PUSH_LOCALMEM_LONG_2",               "Loc[2]@",            ArguementMode.None),                   //  0x68
            new Instruction("POP_LOCALMEM_LONG_2",                "Loc[2]!",            ArguementMode.None),                   //  0x69
            new Instruction("EFFECT_LOCALMEM_LONG_2",             "Loc[2] with",        ArguementMode.Effect),                 //  0x6A
            new Instruction("REFERENCE_LOCALMEM_LONG_2",          "&Loc[2]",            ArguementMode.None),                   //  0x6B
            new Instruction("PUSH_LOCALMEM_LONG_3",               "Loc[3]@",            ArguementMode.None),                   //  0x6C
            new Instruction("POP_LOCALMEM_LONG_3",                "Loc[3]!",            ArguementMode.None),                   //  0x6D
            new Instruction("EFFECT_LOCALMEM_LONG_3",             "Loc[3] with",        ArguementMode.Effect),                 //  0x6E
            new Instruction("REFERENCE_LOCALMEM_LONG_3",          "&Loc[3]",            ArguementMode.None),                   //  0x6F
            new Instruction("PUSH_LOCALMEM_LONG_4",               "Loc[4]@",            ArguementMode.None),                   //  0x70
            new Instruction("POP_LOCALMEM_LONG_4",                "Loc[4]!",            ArguementMode.None),                   //  0x71
            new Instruction("EFFECT_LOCALMEM_LONG_4",             "Loc[4] with",        ArguementMode.Effect),                 //  0x72
            new Instruction("REFERENCE_LOCALMEM_LONG_4",          "&Loc[4]",            ArguementMode.None),                   //  0x73
            new Instruction("PUSH_LOCALMEM_LONG_5",               "Loc[5]@",            ArguementMode.None),                   //  0x74
            new Instruction("POP_LOCALMEM_LONG_5",                "Loc[5]!",            ArguementMode.None),                   //  0x75
            new Instruction("EFFECT_LOCALMEM_LONG_5",             "Loc[5] with",        ArguementMode.Effect),                 //  0x76
            new Instruction("REFERENCE_LOCALMEM_LONG_5",          "&Loc[5]",            ArguementMode.None),                   //  0x77
            new Instruction("PUSH_LOCALMEM_LONG_6",               "Loc[6]@",            ArguementMode.None),                   //  0x78
            new Instruction("POP_LOCALMEM_LONG_6",                "Loc[6]!",            ArguementMode.None),                   //  0x79
            new Instruction("EFFECT_LOCALMEM_LONG_6",             "Loc[6] with",        ArguementMode.Effect),                 //  0x7A
            new Instruction("REFERENCE_LOCALMEM_LONG_6",          "&Loc[6]",            ArguementMode.None),                   //  0x7B
            new Instruction("PUSH_LOCALMEM_LONG_7",               "Loc[7]@",            ArguementMode.None),                   //  0x7C
            new Instruction("POP_LOCALMEM_LONG_7",                "Loc[7]!",            ArguementMode.None),                   //  0x7D
            new Instruction("EFFECT_LOCALMEM_LONG_7",             "Loc[7] with",        ArguementMode.Effect),                 //  0x7E
            new Instruction("REFERENCE_LOCALMEM_LONG_7",          "&Loc[7]",            ArguementMode.None),                   //  0x7F
            new Instruction("PUSH_MAINMEM_BYTE",                  "byte Mem[]@",        ArguementMode.None),                   //  0x80
            new Instruction("POP_MAINMEM_BYTE",                   "byte Mem[]!",        ArguementMode.None),                   //  0x81
            new Instruction("EFFECT_MAINMEM_BYTE",                "byte Mem[] with",    ArguementMode.Effect),                 //  0x82
            new Instruction("REFERENCE_MAINMEM_BYTE",             "byte &Mem[]",        ArguementMode.None),                   //  0x83
            new Instruction("PUSH_OBJECTMEM_BYTE",                "byte Obj[]@",        ArguementMode.UnsignedOffset),         //  0x84
            new Instruction("POP_OBJECTMEM_BYTE",                 "byte Obj[]!",        ArguementMode.UnsignedOffset),         //  0x85
            new Instruction("EFFECT_OBJECTMEM_BYTE",              "byte Obj[] with",    ArguementMode.UnsignedEffectedOffset), //  0x86
            new Instruction("REFERENCE_OBJECTMEM_BYTE",           "byte &Obj[]",        ArguementMode.UnsignedOffset),         //  0x87
            new Instruction("PUSH_VARIABLEMEM_BYTE",              "byte Var[]@",        ArguementMode.UnsignedOffset),         //  0x88
            new Instruction("POP_VARIABLEMEM_BYTE",               "byte Var[]!",        ArguementMode.UnsignedOffset),         //  0x89
            new Instruction("EFFECT_VARIABLEMEM_BYTE",            "byte Var[] with",    ArguementMode.UnsignedEffectedOffset), //  0x8A
            new Instruction("REFERENCE_VARIABLEMEM_BYTE",         "byte &Var[]",        ArguementMode.UnsignedOffset),         //  0x8B
            new Instruction("PUSH_LOCALMEM_BYTE",                 "byte Loc[]@",        ArguementMode.UnsignedOffset),         //  0x8C
            new Instruction("POP_LOCALMEM_BYTE",                  "byte Loc[]!",        ArguementMode.UnsignedOffset),         //  0x8D
            new Instruction("EFFECT_LOCALMEM_BYTE",               "byte Loc[] then",    ArguementMode.UnsignedEffectedOffset), //  0x8E
            new Instruction("REFERENCE_LOCALMEM_BYTE",            "byte &Loc[]",        ArguementMode.UnsignedOffset),         //  0x8F
            new Instruction("PUSH_INDEXED_MAINMEM_BYTE",          "byte Mem[idx]@",     ArguementMode.None),                   //  0x90
            new Instruction("POP_INDEXED_MAINMEM_BYTE",           "byte Mem[idx]!",     ArguementMode.None),                   //  0x91
            new Instruction("EFFECT_INDEXED_MAINMEM_BYTE",        "byte Mem[idx] with", ArguementMode.Effect),                 //  0x92
            new Instruction("REFERENCE_INDEXED_MAINMEM_BYTE",     "byte &Mem[idx]",     ArguementMode.None),                   //  0x93
            new Instruction("PUSH_INDEXED_OBJECTMEM_BYTE",        "byte Obj[idx]@",     ArguementMode.UnsignedOffset),         //  0x94
            new Instruction("POP_INDEXED_OBJECTMEM_BYTE",         "byte Obj[idx]!",     ArguementMode.UnsignedOffset),         //  0x95
            new Instruction("EFFECT_INDEXED_OBJECTMEM_BYTE",      "byte Obj[idx] with", ArguementMode.UnsignedEffectedOffset), //  0x96
            new Instruction("REFERENCE_INDEXED_OBJECTMEM_BYTE",   "byte &Obj[idx]",     ArguementMode.UnsignedOffset),         //  0x97
            new Instruction("PUSH_INDEXED_VARIABLEMEM_BYTE",      "byte Var[idx]@",     ArguementMode.UnsignedOffset),         //  0x98
            new Instruction("POP_INDEXED_VARIABLEMEM_BYTE",       "byte Var[idx]!",     ArguementMode.UnsignedOffset),         //  0x99
            new Instruction("EFFECT_INDEXED_VARIABLEMEM_BYTE",    "byte Var[idx] with", ArguementMode.UnsignedEffectedOffset), //  0x9A
            new Instruction("REFERENCE_INDEXED_VARIABLEMEM_BYTE", "byte &Var[idx]",     ArguementMode.UnsignedOffset),         //  0x9B
            new Instruction("PUSH_INDEXED_LOCALMEM_BYTE",         "byte Loc[idx]@",     ArguementMode.UnsignedOffset),         //  0x9C
            new Instruction("POP_INDEXED_LOCALMEM_BYTE",          "byte Loc[idx]!",     ArguementMode.UnsignedOffset),         //  0x9D
            new Instruction("EFFECT_INDEXED_LOCALMEM_BYTE",       "byte Loc[idx] with", ArguementMode.UnsignedEffectedOffset), //  0x9E
            new Instruction("REFERENCE_INDEXED_LOCALMEM_BYTE",    "byte &Loc[idx]",     ArguementMode.UnsignedOffset),         //  0x9F
            new Instruction("PUSH_MAINMEM_WORD",                  "word Mem[]@",        ArguementMode.None),                   //  0xA0
            new Instruction("POP_MAINMEM_WORD",                   "word Mem[]!",        ArguementMode.None),                   //  0xA1
            new Instruction("EFFECT_MAINMEM_WORD",                "word Mem[] with",    ArguementMode.Effect),                 //  0xA2
            new Instruction("REFERENCE_MAINMEM_WORD",             "word &Mem[]",        ArguementMode.None),                   //  0xA3
            new Instruction("PUSH_OBJECTMEM_WORD",                "word Obj[]@",        ArguementMode.UnsignedOffset),         //  0xA4
            new Instruction("POP_OBJECTMEM_WORD",                 "word Obj[]!",        ArguementMode.UnsignedOffset),         //  0xA5
            new Instruction("EFFECT_OBJECTMEM_WORD",              "word Obj[] with",    ArguementMode.UnsignedEffectedOffset), //  0xA6
            new Instruction("REFERENCE_OBJECTMEM_WORD",           "word &Obj[]",        ArguementMode.UnsignedOffset),         //  0xA7
            new Instruction("PUSH_VARIABLEMEM_WORD",              "word Var[]@",        ArguementMode.UnsignedOffset),         //  0xA8
            new Instruction("POP_VARIABLEMEM_WORD",               "word Var[]!",        ArguementMode.UnsignedOffset),         //  0xA9
            new Instruction("EFFECT_VARIABLEMEM_WORD",            "word Var[] with",    ArguementMode.UnsignedEffectedOffset), //  0xAA
            new Instruction("REFERENCE_VARIABLEMEM_WORD",         "word &Var[]",        ArguementMode.UnsignedOffset),         //  0xAB
            new Instruction("PUSH_LOCALMEM_WORD",                 "word Loc[]@",        ArguementMode.UnsignedOffset),         //  0xAC
            new Instruction("POP_LOCALMEM_WORD",                  "word Loc[]!",        ArguementMode.UnsignedOffset),         //  0xAD
            new Instruction("EFFECT_LOCALMEM_WORD",               "word Loc[] with",    ArguementMode.UnsignedEffectedOffset), //  0xAE
            new Instruction("REFERENCE_LOCALMEM_WORD",            "word &Loc[]",        ArguementMode.UnsignedOffset),         //  0xAF
            new Instruction("PUSH_INDEXED_MAINMEM_WORD",          "word Mem[idx]@",     ArguementMode.None),                   //  0xB0
            new Instruction("POP_INDEXED_MAINMEM_WORD",           "word Mem[idx]!",     ArguementMode.None),                   //  0xB1
            new Instruction("EFFECT_INDEXED_MAINMEM_WORD",        "word Mem[idx] with", ArguementMode.Effect),                 //  0xB2
            new Instruction("REFERENCE_INDEXED_MAINMEM_WORD",     "word &Mem[idx]",     ArguementMode.None),                   //  0xB3
            new Instruction("PUSH_INDEXED_OBJECTMEM_WORD",        "word Obj[idx]@",     ArguementMode.UnsignedOffset),         //  0xB4
            new Instruction("POP_INDEXED_OBJECTMEM_WORD",         "word Obj[idx]!",     ArguementMode.UnsignedOffset),         //  0xB5
            new Instruction("EFFECT_INDEXED_OBJECTMEM_WORD",      "word Obj[idx] with", ArguementMode.UnsignedEffectedOffset), //  0xB6
            new Instruction("REFERENCE_INDEXED_OBJECTMEM_WORD",   "word &Obj[idx]",     ArguementMode.UnsignedOffset),         //  0xB7
            new Instruction("PUSH_INDEXED_VARIABLEMEM_WORD",      "word Var[idx]@",     ArguementMode.UnsignedOffset),         //  0xB8
            new Instruction("POP_INDEXED_VARIABLEMEM_WORD",       "word Var[idx]!",     ArguementMode.UnsignedOffset),         //  0xB9
            new Instruction("EFFECT_INDEXED_VARIABLEMEM_WORD",    "word Var[idx] with", ArguementMode.UnsignedEffectedOffset), //  0xBA
            new Instruction("REFERENCE_INDEXED_VARIABLEMEM_WORD", "word &Var[idx]",     ArguementMode.UnsignedOffset),         //  0xBB
            new Instruction("PUSH_INDEXED_LOCALMEM_WORD",         "word Loc[idx]@",     ArguementMode.UnsignedOffset),         //  0xBC
            new Instruction("POP_INDEXED_LOCALMEM_WORD",          "word Loc[idx]!",     ArguementMode.UnsignedOffset),         //  0xBD
            new Instruction("EFFECT_INDEXED_LOCALMEM_WORD",       "word Loc[idx] with", ArguementMode.UnsignedEffectedOffset), //  0xBE
            new Instruction("REFERENCE_INDEXED_LOCALMEM_WORD",    "word &Loc[idx]",     ArguementMode.UnsignedOffset),         //  0xBF
            new Instruction("PUSH_MAINMEM_LONG",                  "Mem[]@",             ArguementMode.None),                   //  0xC0
            new Instruction("POP_MAINMEM_LONG",                   "Mem[]!",             ArguementMode.None),                   //  0xC1
            new Instruction("EFFECT_MAINMEM_LONG",                "Mem[] with",         ArguementMode.Effect),                 //  0xC2
            new Instruction("REFERENCE_MAINMEM_LONG",             "&Mem[]",             ArguementMode.None),                   //  0xC3
            new Instruction("PUSH_OBJECTMEM_LONG",                "Obj[]@",             ArguementMode.UnsignedOffset),         //  0xC4
            new Instruction("POP_OBJECTMEM_LONG",                 "Obj[]!",             ArguementMode.UnsignedOffset),         //  0xC5
            new Instruction("EFFECT_OBJECTMEM_LONG",              "Obj[] with",         ArguementMode.UnsignedEffectedOffset), //  0xC6
            new Instruction("REFERENCE_OBJECTMEM_LONG",           "&Obj[]",             ArguementMode.UnsignedOffset),         //  0xC7
            new Instruction("PUSH_VARIABLEMEM_LONG",              "Var[]@",             ArguementMode.UnsignedOffset),         //  0xC8
            new Instruction("POP_VARIABLEMEM_LONG",               "Var[]!",             ArguementMode.UnsignedOffset),         //  0xC9
            new Instruction("EFFECT_VARIABLEMEM_LONG",            "Var[] with",         ArguementMode.UnsignedEffectedOffset), //  0xCA
            new Instruction("REFERENCE_VARIABLEMEM_LONG",         "&Var[]",             ArguementMode.UnsignedOffset),         //  0xCB
            new Instruction("PUSH_LOCALMEM_LONG",                 "Loc[]@",             ArguementMode.UnsignedOffset),         //  0xCC
            new Instruction("POP_LOCALMEM_LONG",                  "Loc[]!",             ArguementMode.UnsignedOffset),         //  0xCD
            new Instruction("EFFECT_LOCALMEM_LONG",               "Loc[] with",         ArguementMode.UnsignedEffectedOffset), //  0xCE
            new Instruction("REFERENCE_LOCALMEM_LONG",            "&Loc[]",             ArguementMode.UnsignedOffset),         //  0xCF
            new Instruction("PUSH_INDEXED_MAINMEM_LONG",          "Mem[idx]@",          ArguementMode.None),                   //  0xD0
            new Instruction("POP_INDEXED_MAINMEM_LONG",           "Mem[idx]!",          ArguementMode.None),                   //  0xD1
            new Instruction("EFFECT_INDEXED_MAINMEM_LONG",        "Mem[idx] with",      ArguementMode.Effect),                 //  0xD2
            new Instruction("REFERENCE_INDEXED_MAINMEM_LONG",     "&Mem[idx]",          ArguementMode.None),                   //  0xD3
            new Instruction("PUSH_INDEXED_OBJECTMEM_LONG",        "Obj[idx]@",          ArguementMode.UnsignedOffset),         //  0xD4
            new Instruction("POP_INDEXED_OBJECTMEM_LONG",         "Obj[idx]!",          ArguementMode.UnsignedOffset),         //  0xD5
            new Instruction("EFFECT_INDEXED_OBJECTMEM_LONG",      "Obj[idx] with",      ArguementMode.UnsignedEffectedOffset), //  0xD6
            new Instruction("REFERENCE_INDEXED_OBJECTMEM_LONG",   "&Obj[idx]",          ArguementMode.UnsignedOffset),         //  0xD7
            new Instruction("PUSH_INDEXED_VARIABLEMEM_LONG",      "Var[idx]@",          ArguementMode.UnsignedOffset),         //  0xD8
            new Instruction("POP_INDEXED_VARIABLEMEM_LONG",       "Var[idx]!",          ArguementMode.UnsignedOffset),         //  0xD9
            new Instruction("EFFECT_INDEXED_VARIABLEMEM_LONG",    "Var[idx] with",      ArguementMode.UnsignedEffectedOffset), //  0xDA
            new Instruction("REFERENCE_INDEXED_VARIABLEMEM_LONG", "&Var[idx]",          ArguementMode.UnsignedOffset),         //  0xDB
            new Instruction("PUSH_INDEXED_LOCALMEM_LONG",         "Loc[idx]@",          ArguementMode.UnsignedOffset),         //  0xDC
            new Instruction("POP_INDEXED_LOCALMEM_LONG",          "Loc[idx]!",          ArguementMode.UnsignedOffset),         //  0xDD
            new Instruction("EFFECT_INDEXED_LOCALMEM_LONG",       "Loc[idx] with",      ArguementMode.UnsignedEffectedOffset), //  0xDE
            new Instruction("REFERENCE_INDEXED_LOCALMEM_LONG",    "&Loc[idx]",          ArguementMode.UnsignedOffset),         //  0xDF
            new Instruction("ROTATE_RIGHT",                       "a->b",               ArguementMode.None),                   //  0xE0
            new Instruction("ROTATE_LEFT",                        "a<-b",               ArguementMode.None),                   //  0xE1
            new Instruction("SHIFT_RIGHT",                        "a>>b",               ArguementMode.None),                   //  0xE2
            new Instruction("SHIFT_LEFT",                         "a<<b",               ArguementMode.None),                   //  0xE3
            new Instruction("LIMIT_MIN",                          "a#>b",               ArguementMode.None),                   //  0xE4
            new Instruction("LIMIT_MAX",                          "a#<b",               ArguementMode.None),                   //  0xE5
            new Instruction("NEGATE",                             "-a",                 ArguementMode.None),                   //  0xE6
            new Instruction("COMPLEMENT",                         "~a",                 ArguementMode.None),                   //  0xE7
            new Instruction("BIT_AND",                            "a&b",                ArguementMode.None),                   //  0xE8
            new Instruction("ABSOLUTE_VALUE",                     "||a",                ArguementMode.None),                   //  0xE9
            new Instruction("BIT_OR",                             "a|b",                ArguementMode.None),                   //  0xEA
            new Instruction("BIT_XOR",                            "a^b",                ArguementMode.None),                   //  0xEB
            new Instruction("ADD",                                "a+b",                ArguementMode.None),                   //  0xEC
            new Instruction("SUBTRACT",                           "a-b",                ArguementMode.None),                   //  0xED
            new Instruction("ARITH_SHIFT_RIGHT",                  "a~>b",               ArguementMode.None),                   //  0xEE
            new Instruction("BIT_REVERSE",                        "a><b",               ArguementMode.None),                   //  0xEF
            new Instruction("LOGICAL_AND",                        "a and b",            ArguementMode.None),                   //  0xF0
            new Instruction("ENCODE",                             ">|a",                ArguementMode.None),                   //  0xF1
            new Instruction("LOGICAL_OR",                         "a or b",             ArguementMode.None),                   //  0xF2
            new Instruction("DECODE",                             "|<a",                ArguementMode.None),                   //  0xF3
            new Instruction("MULTIPLY",                           "a*b",                ArguementMode.None),                   //  0xF4
            new Instruction("MULTIPLY_HI",                        "(a*b)>>32",          ArguementMode.None),                   //  0xF5
            new Instruction("DIVIDE",                             "a/b",                ArguementMode.None),                   //  0xF6
            new Instruction("MODULO",                             "a mod b",            ArguementMode.None),                   //  0xF7
            new Instruction("SQUARE_ROOT",                        "sqrt(a)",            ArguementMode.None),                   //  0xF8
            new Instruction("LESS",                               "a<b",                ArguementMode.None),                   //  0xF9
            new Instruction("GREATER",                            "a>b",                ArguementMode.None),                   //  0xFA
            new Instruction("NOT_EQUAL",                          "a<>b",               ArguementMode.None),                   //  0xFB
            new Instruction("EQUAL",                              "a==b",               ArguementMode.None),                   //  0xFC
            new Instruction("LESS_EQUAL",                         "a=<b",               ArguementMode.None),                   //  0xFD
            new Instruction("GREATER_EQUAL",                      "a=>b",               ArguementMode.None),                   //  0xFE
            new Instruction("LOGICAL_NOT",                        "not a",              ArguementMode.None)                    //  0xFF
        };
    }
}
