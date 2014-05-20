﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011-2014, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Tue, May 20, 2014 16:08+0200 for FHIR v0.2.1
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Resource for capturing binary data
    /// </summary>
    [FhirType("Binary", IsResource=true)]
    [DataContract]
    public partial class Binary : Hl7.Fhir.Model.Resource, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Binary contents
        /// </summary>
        [FhirElement("content", XmlSerialization=XmlSerializationHint.TextNode, Order=70)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public byte[] Content
        {
            get { return _Content; }
            set { _Content = value; OnPropertyChanged("Content"); }
        }
        private byte[] _Content;
        
        /// <summary>
        /// Media type of contents
        /// </summary>
        [FhirElement("contentType", XmlSerialization=XmlSerializationHint.Attribute, Order=80)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public string ContentType
        {
            get { return _ContentType; }
            set { _ContentType = value; OnPropertyChanged("ContentType"); }
        }
        private string _ContentType;
        
    }
    
}
