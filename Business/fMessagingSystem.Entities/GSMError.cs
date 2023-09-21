//====================================================================================================
// Code generated with Inertia: BE Gen (Build 2.5.4750.27569)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 08/11/2013 16:32:32 
//====================================================================================================

using System;
using System.ComponentModel;
using System.Runtime.Serialization;


namespace fMessagingSystem.Entities
{
    /// <summary>
    /// Represents a row of GSMError data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class GSMError
    {

        /// <summary>
        /// Gets or sets a string value for the ErrorCode column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ErrorText column.
        /// </summary>
        [DataMember]
        public string ErrorText { get; set; }
    }
}