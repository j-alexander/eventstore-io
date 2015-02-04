﻿namespace EventStoreIO

open System

type Event = {
    Type : string
    Stream : string
    Data : byte[]
    Metadata : byte[]
}