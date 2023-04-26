﻿using MessagePack;
using ShareAttributes;

namespace MsgPackDefineForInject
{

    public class Class1 : CBase1
    {

        public long CT1 { get; set; }
    }


    [MessagePackObject]
    public class Class2 : CBase2
    {

        public long CT2 { get; set; }
    }

    [RequireUnion(114514)]
    [MessagePackObject]
    public class Class3 : Class1
    {

        public long CT3 { get; set; }
    }

    
    [MessagePackObject]
    public class Class4 : CBase4<string>
    {

        public long CT4 { get; set; }
    }

    [GenericUnion(typeof(int))]
    [GenericUnion(typeof(string))]
    [MessagePackObject]
    public class Class5<T> : CBase6<T>
    {
        public long CT5 { get; set; }
    }

    [MessagePackObject]
    public class Class6 : Base3
    {
        [Key(0)]
        public long CT6 { get; set; }
    }


    [GenericUnion(typeof(int))]
    [GenericUnion(typeof(int))]
    [GenericUnion(typeof(string))]
    [GenericUnion(typeof(string))]
    [MessagePackObject]
    public class Class7<T> : CBase6<T>
    {
        public long CT7 { get; set; }
    }


    [RequireUnionGeneric(1,typeof(int))]
    [RequireUnionGeneric(2,typeof(string))]
    [MessagePackObject]
    public class Class8<T> : CBase6<T>
    {
        public long CT8 { get; set; }
    }
}