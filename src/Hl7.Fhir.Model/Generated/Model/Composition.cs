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
    /// A set of resources composed into a single coherent clinical statement with clinical attestation
    /// </summary>
    [FhirType("Composition", IsResource=true)]
    [DataContract]
    public partial class Composition : Hl7.Fhir.Model.Resource, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// The workflow/clinical status of the composition
        /// </summary>
        [FhirEnumeration("CompositionStatus")]
        public enum CompositionStatus
        {
            /// <summary>
            /// This is a preliminary composition or document (also known as initial or interim). The content may be incomplete or unverified.
            /// </summary>
            [EnumLiteral("preliminary")]
            Preliminary,
            /// <summary>
            /// The composition or document is complete and verified by an appropriate person, and no further work is planned.
            /// </summary>
            [EnumLiteral("final")]
            Final,
            /// <summary>
            /// The composition or document has been modified subsequent to being released as "final", and is complete and verified by an authorized person. The modifications added new information to the composition or document, but did not revise existing content.
            /// </summary>
            [EnumLiteral("appended")]
            Appended,
            /// <summary>
            /// The composition or document has been modified subsequent to being released as "final", and is complete and verified by an authorized person.
            /// </summary>
            [EnumLiteral("amended")]
            Amended,
            /// <summary>
            /// The composition or document was originally created/issued in error, and this is an amendment that marks that the entire series should not be considered as valid.
            /// </summary>
            [EnumLiteral("entered in error")]
            EnteredInError,
        }
        
        /// <summary>
        /// The way in which a person authenticated a composition
        /// </summary>
        [FhirEnumeration("CompositionAttestationMode")]
        public enum CompositionAttestationMode
        {
            /// <summary>
            /// The person authenticated the content in their personal capacity.
            /// </summary>
            [EnumLiteral("personal")]
            Personal,
            /// <summary>
            /// The person authenticated the content in their professional capacity.
            /// </summary>
            [EnumLiteral("professional")]
            Professional,
            /// <summary>
            /// The person authenticated the content and accepted legal responsibility for its content.
            /// </summary>
            [EnumLiteral("legal")]
            Legal,
            /// <summary>
            /// The organization authenticated the content as consistent with their policies and procedures.
            /// </summary>
            [EnumLiteral("official")]
            Official,
        }
        
        [FhirType("SectionComponent")]
        [DataContract]
        public partial class SectionComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Label for section
            /// </summary>
            [FhirElement("title", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TitleElement
            {
                get { return _TitleElement; }
                set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
            }
            private Hl7.Fhir.Model.FhirString _TitleElement;
            
            /// <summary>
            /// Label for section
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Title
            {
                get { return TitleElement != null ? TitleElement.Value : null; }
                set
                {
                    if(value == null)
                      TitleElement = null; 
                    else
                      TitleElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Title");
                }
            }
            
            /// <summary>
            /// Classification of section (recommended)
            /// </summary>
            [FhirElement("code", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            private Hl7.Fhir.Model.CodeableConcept _Code;
            
            /// <summary>
            /// If section different to composition
            /// </summary>
            [FhirElement("subject", InSummary=true, Order=60)]
            [References("Patient","Group","Device")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Subject
            {
                get { return _Subject; }
                set { _Subject = value; OnPropertyChanged("Subject"); }
            }
            private Hl7.Fhir.Model.ResourceReference _Subject;
            
            /// <summary>
            /// The actual data for the section
            /// </summary>
            [FhirElement("content", InSummary=true, Order=70)]
            [References()]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Content
            {
                get { return _Content; }
                set { _Content = value; OnPropertyChanged("Content"); }
            }
            private Hl7.Fhir.Model.ResourceReference _Content;
            
            /// <summary>
            /// Nested Section
            /// </summary>
            [FhirElement("section", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Composition.SectionComponent> Section
            {
                get { return _Section; }
                set { _Section = value; OnPropertyChanged("Section"); }
            }
            private List<Hl7.Fhir.Model.Composition.SectionComponent> _Section;
            
        }
        
        
        [FhirType("CompositionEventComponent")]
        [DataContract]
        public partial class CompositionEventComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Code(s) that apply to the event being documented
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            private List<Hl7.Fhir.Model.CodeableConcept> _Code;
            
            /// <summary>
            /// The period covered by the documentation
            /// </summary>
            [FhirElement("period", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Period Period
            {
                get { return _Period; }
                set { _Period = value; OnPropertyChanged("Period"); }
            }
            private Hl7.Fhir.Model.Period _Period;
            
            /// <summary>
            /// Full details for the event(s) the composition consents
            /// </summary>
            [FhirElement("detail", InSummary=true, Order=60)]
            [References()]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> Detail
            {
                get { return _Detail; }
                set { _Detail = value; OnPropertyChanged("Detail"); }
            }
            private List<Hl7.Fhir.Model.ResourceReference> _Detail;
            
        }
        
        
        [FhirType("CompositionAttesterComponent")]
        [DataContract]
        public partial class CompositionAttesterComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// personal | professional | legal | official
            /// </summary>
            [FhirElement("mode", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Code<Hl7.Fhir.Model.Composition.CompositionAttestationMode>> ModeElement
            {
                get { return _ModeElement; }
                set { _ModeElement = value; OnPropertyChanged("ModeElement"); }
            }
            private List<Code<Hl7.Fhir.Model.Composition.CompositionAttestationMode>> _ModeElement;
            
            /// <summary>
            /// personal | professional | legal | official
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<Hl7.Fhir.Model.Composition.CompositionAttestationMode?> Mode
            {
                get { return ModeElement != null ? ModeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      ModeElement = null; 
                    else
                      ModeElement = new List<Code<Hl7.Fhir.Model.Composition.CompositionAttestationMode>>(value.Select(elem=>new Code<Hl7.Fhir.Model.Composition.CompositionAttestationMode>(elem)));
                    OnPropertyChanged("Mode");
                }
            }
            
            /// <summary>
            /// When composition attested
            /// </summary>
            [FhirElement("time", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime TimeElement
            {
                get { return _TimeElement; }
                set { _TimeElement = value; OnPropertyChanged("TimeElement"); }
            }
            private Hl7.Fhir.Model.FhirDateTime _TimeElement;
            
            /// <summary>
            /// When composition attested
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Time
            {
                get { return TimeElement != null ? TimeElement.Value : null; }
                set
                {
                    if(value == null)
                      TimeElement = null; 
                    else
                      TimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
                    OnPropertyChanged("Time");
                }
            }
            
            /// <summary>
            /// Who attested the composition
            /// </summary>
            [FhirElement("party", InSummary=true, Order=60)]
            [References("Patient","Practitioner","Organization")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Party
            {
                get { return _Party; }
                set { _Party = value; OnPropertyChanged("Party"); }
            }
            private Hl7.Fhir.Model.ResourceReference _Party;
            
        }
        
        
        /// <summary>
        /// Logical identifier of composition (version-independent)
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=70)]
        [DataMember]
        public Hl7.Fhir.Model.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        private Hl7.Fhir.Model.Identifier _Identifier;
        
        /// <summary>
        /// Composition editing time
        /// </summary>
        [FhirElement("date", InSummary=true, Order=80)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Composition editing time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if(value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Kind of composition (LOINC if possible)
        /// </summary>
        [FhirElement("type", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        private Hl7.Fhir.Model.CodeableConcept _Type;
        
        /// <summary>
        /// Categorization of Composition
        /// </summary>
        [FhirElement("class", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Class
        {
            get { return _Class; }
            set { _Class = value; OnPropertyChanged("Class"); }
        }
        private Hl7.Fhir.Model.CodeableConcept _Class;
        
        /// <summary>
        /// Human Readable name/title
        /// </summary>
        [FhirElement("title", InSummary=true, Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString TitleElement
        {
            get { return _TitleElement; }
            set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
        }
        private Hl7.Fhir.Model.FhirString _TitleElement;
        
        /// <summary>
        /// Human Readable name/title
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if(value == null)
                  TitleElement = null; 
                else
                  TitleElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Title");
            }
        }
        
        /// <summary>
        /// preliminary | final | appended | amended | entered in error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.Composition.CompositionStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        private Code<Hl7.Fhir.Model.Composition.CompositionStatus> _StatusElement;
        
        /// <summary>
        /// preliminary | final | appended | amended | entered in error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.Composition.CompositionStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.Composition.CompositionStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// As defined by affinity domain
        /// </summary>
        [FhirElement("confidentiality", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Coding Confidentiality
        {
            get { return _Confidentiality; }
            set { _Confidentiality = value; OnPropertyChanged("Confidentiality"); }
        }
        private Hl7.Fhir.Model.Coding _Confidentiality;
        
        /// <summary>
        /// Who and/or what the composition is about
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=140)]
        [References("Patient","Practitioner","Group","Device","Location")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        private Hl7.Fhir.Model.ResourceReference _Subject;
        
        /// <summary>
        /// Who and/or what authored the composition
        /// </summary>
        [FhirElement("author", InSummary=true, Order=150)]
        [References("Practitioner","Device","Patient","RelatedPerson")]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Author
        {
            get { return _Author; }
            set { _Author = value; OnPropertyChanged("Author"); }
        }
        private List<Hl7.Fhir.Model.ResourceReference> _Author;
        
        /// <summary>
        /// Attests to accuracy of composition
        /// </summary>
        [FhirElement("attester", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Composition.CompositionAttesterComponent> Attester
        {
            get { return _Attester; }
            set { _Attester = value; OnPropertyChanged("Attester"); }
        }
        private List<Hl7.Fhir.Model.Composition.CompositionAttesterComponent> _Attester;
        
        /// <summary>
        /// Org which maintains the composition
        /// </summary>
        [FhirElement("custodian", InSummary=true, Order=170)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Custodian
        {
            get { return _Custodian; }
            set { _Custodian = value; OnPropertyChanged("Custodian"); }
        }
        private Hl7.Fhir.Model.ResourceReference _Custodian;
        
        /// <summary>
        /// The clinical event/act/item being documented
        /// </summary>
        [FhirElement("event", InSummary=true, Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.Composition.CompositionEventComponent Event
        {
            get { return _Event; }
            set { _Event = value; OnPropertyChanged("Event"); }
        }
        private Hl7.Fhir.Model.Composition.CompositionEventComponent _Event;
        
        /// <summary>
        /// Context of the conposition
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=190)]
        [References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        private Hl7.Fhir.Model.ResourceReference _Encounter;
        
        /// <summary>
        /// Composition is broken into sections
        /// </summary>
        [FhirElement("section", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Composition.SectionComponent> Section
        {
            get { return _Section; }
            set { _Section = value; OnPropertyChanged("Section"); }
        }
        private List<Hl7.Fhir.Model.Composition.SectionComponent> _Section;
        
    }
    
}
