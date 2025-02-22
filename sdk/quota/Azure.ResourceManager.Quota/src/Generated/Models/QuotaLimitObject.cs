// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> The resource quota limit value. </summary>
    public partial class QuotaLimitObject : QuotaLimitJsonObject
    {
        /// <summary> Initializes a new instance of QuotaLimitObject. </summary>
        /// <param name="value"> The quota/limit value. </param>
        public QuotaLimitObject(int value)
        {
            Value = value;
            LimitObjectType = Models.LimitType.LimitValue;
        }

        /// <summary> Initializes a new instance of QuotaLimitObject. </summary>
        /// <param name="limitObjectType"> The limit object type. </param>
        /// <param name="value"> The quota/limit value. </param>
        /// <param name="limitType"> The quota or usages limit types. </param>
        internal QuotaLimitObject(LimitType limitObjectType, int value, QuotaLimitType? limitType) : base(limitObjectType)
        {
            Value = value;
            LimitType = limitType;
            LimitObjectType = limitObjectType;
        }

        /// <summary> The quota/limit value. </summary>
        public int Value { get; set; }
        /// <summary> The quota or usages limit types. </summary>
        public QuotaLimitType? LimitType { get; set; }
    }
}
