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
    /// (informative) A response to a scheduled appointment for a patient and/or practitioner(s)
    /// </summary>
    [FhirType("AppointmentResponse", IsResource=true)]
    [DataContract]
    public partial class AppointmentResponse : Hl7.Fhir.Model.Resource, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// The Participation status of an appointment
        /// </summary>
        [FhirEnumeration("ParticipantStatus")]
        public enum ParticipantStatus
        {
            /// <summary>
            /// The appointment participant has accepted that they can attend the appointment at the time specified in the AppointmentResponse.
            /// </summary>
            [EnumLiteral("accepted")]
            Accepted,
            /// <summary>
            /// The appointment participant has declined the appointment.
            /// </summary>
            [EnumLiteral("declined")]
            Declined,
            /// <summary>
            /// The appointment participant has tentatively accepted the appointment.
            /// </summary>
            [EnumLiteral("tentative")]
            Tentative,
            /// <summary>
            /// The participant has in-process the appointment.
            /// </summary>
            [EnumLiteral("in-process")]
            InProcess,
            /// <summary>
            /// The participant has completed the appointment.
            /// </summary>
            [EnumLiteral("completed")]
            Completed,
            /// <summary>
            /// This is the intitial status of an appointment participant until a participant has replied. It implies that there is no commitment for the appointment.
            /// </summary>
            [EnumLiteral("needs-action")]
            NeedsAction,
        }
        
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
        /// Parent appointment that this response is replying to
        /// </summary>
        [FhirElement("appointment", Order=80)]
        [References("Appointment")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Appointment
        {
            get { return _Appointment; }
            set { _Appointment = value; OnPropertyChanged("Appointment"); }
        }
        private Hl7.Fhir.Model.ResourceReference _Appointment;
        
        /// <summary>
        /// Role of participant in the appointment
        /// </summary>
        [FhirElement("participantType", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> ParticipantType
        {
            get { return _ParticipantType; }
            set { _ParticipantType = value; OnPropertyChanged("ParticipantType"); }
        }
        private List<Hl7.Fhir.Model.CodeableConcept> _ParticipantType;
        
        /// <summary>
        /// A Person of device that is participating in the appointment, usually Practitioner, Patient, RelatedPerson or Device
        /// </summary>
        [FhirElement("individual", Order=100)]
        [References()]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Individual
        {
            get { return _Individual; }
            set { _Individual = value; OnPropertyChanged("Individual"); }
        }
        private List<Hl7.Fhir.Model.ResourceReference> _Individual;
        
        /// <summary>
        /// accepted | declined | tentative | in-process | completed | needs-action
        /// </summary>
        [FhirElement("participantStatus", Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.AppointmentResponse.ParticipantStatus> ParticipantStatus_Element
        {
            get { return _ParticipantStatus_Element; }
            set { _ParticipantStatus_Element = value; OnPropertyChanged("ParticipantStatus_Element"); }
        }
        private Code<Hl7.Fhir.Model.AppointmentResponse.ParticipantStatus> _ParticipantStatus_Element;
        
        /// <summary>
        /// accepted | declined | tentative | in-process | completed | needs-action
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.AppointmentResponse.ParticipantStatus? ParticipantStatus_
        {
            get { return ParticipantStatus_Element != null ? ParticipantStatus_Element.Value : null; }
            set
            {
                if(value == null)
                  ParticipantStatus_Element = null; 
                else
                  ParticipantStatus_Element = new Code<Hl7.Fhir.Model.AppointmentResponse.ParticipantStatus>(value);
                OnPropertyChanged("ParticipantStatus_");
            }
        }
        
        /// <summary>
        /// Additional comments about the appointment
        /// </summary>
        [FhirElement("comment", Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CommentElement
        {
            get { return _CommentElement; }
            set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
        }
        private Hl7.Fhir.Model.FhirString _CommentElement;
        
        /// <summary>
        /// Additional comments about the appointment
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
        /// Date/Time that the appointment is to take place
        /// </summary>
        [FhirElement("start", Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.Instant StartElement
        {
            get { return _StartElement; }
            set { _StartElement = value; OnPropertyChanged("StartElement"); }
        }
        private Hl7.Fhir.Model.Instant _StartElement;
        
        /// <summary>
        /// Date/Time that the appointment is to take place
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public DateTimeOffset? Start
        {
            get { return StartElement != null ? StartElement.Value : null; }
            set
            {
                if(value == null)
                  StartElement = null; 
                else
                  StartElement = new Hl7.Fhir.Model.Instant(value);
                OnPropertyChanged("Start");
            }
        }
        
        /// <summary>
        /// Date/Time that the appointment is to conclude
        /// </summary>
        [FhirElement("end", Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.Instant EndElement
        {
            get { return _EndElement; }
            set { _EndElement = value; OnPropertyChanged("EndElement"); }
        }
        private Hl7.Fhir.Model.Instant _EndElement;
        
        /// <summary>
        /// Date/Time that the appointment is to conclude
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public DateTimeOffset? End
        {
            get { return EndElement != null ? EndElement.Value : null; }
            set
            {
                if(value == null)
                  EndElement = null; 
                else
                  EndElement = new Hl7.Fhir.Model.Instant(value);
                OnPropertyChanged("End");
            }
        }
        
        /// <summary>
        /// Who recorded the appointment response
        /// </summary>
        [FhirElement("lastModifiedBy", Order=150)]
        [References("Practitioner","Patient","RelatedPerson")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference LastModifiedBy
        {
            get { return _LastModifiedBy; }
            set { _LastModifiedBy = value; OnPropertyChanged("LastModifiedBy"); }
        }
        private Hl7.Fhir.Model.ResourceReference _LastModifiedBy;
        
        /// <summary>
        /// Date when the response was recorded or last updated
        /// </summary>
        [FhirElement("lastModified", Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime LastModifiedElement
        {
            get { return _LastModifiedElement; }
            set { _LastModifiedElement = value; OnPropertyChanged("LastModifiedElement"); }
        }
        private Hl7.Fhir.Model.FhirDateTime _LastModifiedElement;
        
        /// <summary>
        /// Date when the response was recorded or last updated
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
