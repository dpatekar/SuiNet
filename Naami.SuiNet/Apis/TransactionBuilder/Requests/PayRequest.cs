﻿using System.Runtime.Serialization;
using Naami.SuiNet.Types;

namespace Naami.SuiNet.Apis.TransactionBuilder.Requests;

[DataContract]
public record PayRequest(
    [property: DataMember(Name = "signer")]
    SuiAddress Signer,
    [property: DataMember(Name = "input_coins")]
    ObjectId[] InputCoins,
    [property: DataMember(Name = "recipients")]
    SuiAddress[] Recipients,
    [property: DataMember(Name = "amounts")]
    ulong[] Amounts,
    [property: DataMember(Name = "gas_budget")]
    ulong GasBudget
)
{
    [property: DataMember(Name = "gas")] public ObjectId? Gas { get; set; }
}