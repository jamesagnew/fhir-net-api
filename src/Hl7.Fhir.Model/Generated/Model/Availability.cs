using System;
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
    /// (informative) A container for slot(s) of time that may be available for booking appointments
    /// </summary>
    [FhirType("Availability", IsResource=true)]
    [DataContract]
    public partial class Availability : Hl7.Fhir.Model.Resource, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// External Ids for this item
        /// </summary>
        [FhirElement("identifier", Order=70)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// The type(s) of appointments that can be booked into slots attached to this availability resource (ideally this would be an identifiable service - which is at a location, rather than the location itself). (This may be over-ridden by a slot itself)
        /// </summary>
        [FhirElement("type", Order=80)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        private List<Hl7.Fhir.Model.CodeableConcept> _Type;
        
        /// <summary>
        /// The resource this availability resource is providing availability information for. These are expected to usually be one of Location, Practitioner, Device, Patient or RelatedPerson
        /// </summary>
        [FhirElement("individual", Order=90)]
        [References()]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Individual
        {
            get { return _Individual; }
            set { _Individual = value; OnPropertyChanged("Individual"); }
        }
        private Hl7.Fhir.Model.ResourceReference _Individual;
        
        /// <summary>
        /// The period of time that the slots that are attached to this availability resource cover (even if none exist). These  cover the amount of time that an organization's planning horizon; the interval for which they are currently accepting appointments. This does not define a "template" for planning outside these dates
        /// </summary>
        [FhirElement("planningHorizon", Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.Period PlanningHorizon
        {
            get { return _PlanningHorizon; }
            set { _PlanningHorizon = value; OnPropertyChanged("PlanningHorizon"); }
        }
        private Hl7.Fhir.Model.Period _PlanningHorizon;
        
        /// <summary>
        /// Comments on the availability to describe any extended information. Such as custom constraints on the slot(s) that may be associated
        /// </summary>
        [FhirElement("comment", Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CommentElement
        {
            get { return _CommentElement; }
            set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
        }
        private Hl7.Fhir.Model.FhirString _CommentElement;
        
        /// <summary>
        /// Comments on the availability to describe any extended information. Such as custom constraints on the slot(s) that may be associated
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Comment
        {
            get { return CommentElement != null ? CommentElement.Value : null; }
            set
            {
                if(value == null)
                  CommentElement = null; 
                else
                  CommentElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Comment");
            }
        }
        
        /// <summary>
        /// When this availability was created, or last revised
        /// </summary>
        [FhirElement("lastModified", Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime LastModifiedElement
        {
            get { return _LastModifiedElement; }
            set { _LastModifiedElement = value; OnPropertyChanged("LastModifiedElement"); }
        }
        private Hl7.Fhir.Model.FhirDateTime _LastModifiedElement;
        
        /// <summary>
        /// When this availability was created, or last revised
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string LastModified
        {
            get { return LastModifiedElement != null ? LastModifiedElement.Value : null; }
            set
            {
                if(value == null)
                  LastModifiedElement = null; 
                else
                  LastModifiedElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("LastModified");
            }
        }
        
    }
    
}
