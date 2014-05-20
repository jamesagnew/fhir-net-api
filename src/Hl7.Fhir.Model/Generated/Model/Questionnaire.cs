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
    /// A structured set of questions
    /// </summary>
    [FhirType("Questionnaire", IsResource=true)]
    [DataContract]
    public partial class Questionnaire : Hl7.Fhir.Model.Resource, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Lifecycle status of the questionnaire
        /// </summary>
        [FhirEnumeration("QuestionnaireStatus")]
        public enum QuestionnaireStatus
        {
            /// <summary>
            /// This Questionnaire is not ready for official use.
            /// </summary>
            [EnumLiteral("draft")]
            Draft,
            /// <summary>
            /// This Questionnaire is ready for use.
            /// </summary>
            [EnumLiteral("published")]
            Published,
            /// <summary>
            /// This Questionnaire should no longer be used to gather data.
            /// </summary>
            [EnumLiteral("retired")]
            Retired,
        }
        
        /// <summary>
        /// The expected format of an answer
        /// </summary>
        [FhirEnumeration("AnswerFormat")]
        public enum AnswerFormat
        {
            /// <summary>
            /// Answer is a floating point number.
            /// </summary>
            [EnumLiteral("decimal")]
            Decimal,
            /// <summary>
            /// Answer is an integer.
            /// </summary>
            [EnumLiteral("integer")]
            Integer,
            /// <summary>
            /// Answer is a yes/no answer.
            /// </summary>
            [EnumLiteral("boolean")]
            Boolean,
            /// <summary>
            /// Answer is a date.
            /// </summary>
            [EnumLiteral("date")]
            Date,
            /// <summary>
            /// Answer is a short (few words to short sentence) free-text entry.
            /// </summary>
            [EnumLiteral("string")]
            String,
            /// <summary>
            /// Answer is a long (potentially multi-paragram) free-text entry.
            /// </summary>
            [EnumLiteral("text")]
            Text,
            /// <summary>
            /// Answer is a date and time.
            /// </summary>
            [EnumLiteral("dateTime")]
            DateTime,
            /// <summary>
            /// Answer is a system timestamp.
            /// </summary>
            [EnumLiteral("instant")]
            Instant,
            /// <summary>
            /// Answer is a choice from a list of options.
            /// </summary>
            [EnumLiteral("choice")]
            Choice,
            /// <summary>
            /// Answer is a choice from a list of options or a free-text entry.
            /// </summary>
            [EnumLiteral("open-choice")]
            OpenChoice,
        }
        
        [FhirType("QuestionComponent")]
        [DataContract]
        public partial class QuestionComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// To link questionnaire with questionnaire answers
            /// </summary>
            [FhirElement("linkId", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString LinkIdElement
            {
                get { return _LinkIdElement; }
                set { _LinkIdElement = value; OnPropertyChanged("LinkIdElement"); }
            }
            private Hl7.Fhir.Model.FhirString _LinkIdElement;
            
            /// <summary>
            /// To link questionnaire with questionnaire answers
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string LinkId
            {
                get { return LinkIdElement != null ? LinkIdElement.Value : null; }
                set
                {
                    if(value == null)
                      LinkIdElement = null; 
                    else
                      LinkIdElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("LinkId");
                }
            }
            
            /// <summary>
            /// Concept that represents this section on a questionnaire
            /// </summary>
            [FhirElement("concept", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Coding> Concept
            {
                get { return _Concept; }
                set { _Concept = value; OnPropertyChanged("Concept"); }
            }
            private List<Hl7.Fhir.Model.Coding> _Concept;
            
            /// <summary>
            /// Text of the question as it is shown to the user
            /// </summary>
            [FhirElement("text", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TextElement
            {
                get { return _TextElement; }
                set { _TextElement = value; OnPropertyChanged("TextElement"); }
            }
            private Hl7.Fhir.Model.FhirString _TextElement;
            
            /// <summary>
            /// Text of the question as it is shown to the user
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if(value == null)
                      TextElement = null; 
                    else
                      TextElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Text");
                }
            }
            
            /// <summary>
            /// decimal | integer | boolean | date | string +
            /// </summary>
            [FhirElement("type", InSummary=true, Order=70)]
            [DataMember]
            public Code<Hl7.Fhir.Model.Questionnaire.AnswerFormat> TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            private Code<Hl7.Fhir.Model.Questionnaire.AnswerFormat> _TypeElement;
            
            /// <summary>
            /// decimal | integer | boolean | date | string +
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.Questionnaire.AnswerFormat? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Code<Hl7.Fhir.Model.Questionnaire.AnswerFormat>(value);
                    OnPropertyChanged("Type");
                }
            }
            
            /// <summary>
            /// Must group be included in data results?
            /// </summary>
            [FhirElement("required", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean RequiredElement
            {
                get { return _RequiredElement; }
                set { _RequiredElement = value; OnPropertyChanged("RequiredElement"); }
            }
            private Hl7.Fhir.Model.FhirBoolean _RequiredElement;
            
            /// <summary>
            /// Must group be included in data results?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Required
            {
                get { return RequiredElement != null ? RequiredElement.Value : null; }
                set
                {
                    if(value == null)
                      RequiredElement = null; 
                    else
                      RequiredElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Required");
                }
            }
            
            /// <summary>
            /// Whether the group may repeat
            /// </summary>
            [FhirElement("repeats", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean RepeatsElement
            {
                get { return _RepeatsElement; }
                set { _RepeatsElement = value; OnPropertyChanged("RepeatsElement"); }
            }
            private Hl7.Fhir.Model.FhirBoolean _RepeatsElement;
            
            /// <summary>
            /// Whether the group may repeat
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Repeats
            {
                get { return RepeatsElement != null ? RepeatsElement.Value : null; }
                set
                {
                    if(value == null)
                      RepeatsElement = null; 
                    else
                      RepeatsElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Repeats");
                }
            }
            
            /// <summary>
            /// Valueset containing the possible options
            /// </summary>
            [FhirElement("options", InSummary=true, Order=100)]
            [References("ValueSet")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Options
            {
                get { return _Options; }
                set { _Options = value; OnPropertyChanged("Options"); }
            }
            private Hl7.Fhir.Model.ResourceReference _Options;
            
            /// <summary>
            /// Nested questionnaire group
            /// </summary>
            [FhirElement("group", InSummary=true, Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Questionnaire.GroupComponent> Group
            {
                get { return _Group; }
                set { _Group = value; OnPropertyChanged("Group"); }
            }
            private List<Hl7.Fhir.Model.Questionnaire.GroupComponent> _Group;
            
        }
        
        
        [FhirType("GroupComponent")]
        [DataContract]
        public partial class GroupComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// To link questionnaire with questionnaire answers
            /// </summary>
            [FhirElement("linkId", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString LinkIdElement
            {
                get { return _LinkIdElement; }
                set { _LinkIdElement = value; OnPropertyChanged("LinkIdElement"); }
            }
            private Hl7.Fhir.Model.FhirString _LinkIdElement;
            
            /// <summary>
            /// To link questionnaire with questionnaire answers
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string LinkId
            {
                get { return LinkIdElement != null ? LinkIdElement.Value : null; }
                set
                {
                    if(value == null)
                      LinkIdElement = null; 
                    else
                      LinkIdElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("LinkId");
                }
            }
            
            /// <summary>
            /// Name to be displayed for group
            /// </summary>
            [FhirElement("title", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TitleElement
            {
                get { return _TitleElement; }
                set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
            }
            private Hl7.Fhir.Model.FhirString _TitleElement;
            
            /// <summary>
            /// Name to be displayed for group
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
            /// Concept that represents this section on a questionnaire
            /// </summary>
            [FhirElement("concept", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Coding> Concept
            {
                get { return _Concept; }
                set { _Concept = value; OnPropertyChanged("Concept"); }
            }
            private List<Hl7.Fhir.Model.Coding> _Concept;
            
            /// <summary>
            /// Additional text for the group
            /// </summary>
            [FhirElement("text", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TextElement
            {
                get { return _TextElement; }
                set { _TextElement = value; OnPropertyChanged("TextElement"); }
            }
            private Hl7.Fhir.Model.FhirString _TextElement;
            
            /// <summary>
            /// Additional text for the group
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if(value == null)
                      TextElement = null; 
                    else
                      TextElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Text");
                }
            }
            
            /// <summary>
            /// Must group be included in data results?
            /// </summary>
            [FhirElement("required", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean RequiredElement
            {
                get { return _RequiredElement; }
                set { _RequiredElement = value; OnPropertyChanged("RequiredElement"); }
            }
            private Hl7.Fhir.Model.FhirBoolean _RequiredElement;
            
            /// <summary>
            /// Must group be included in data results?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Required
            {
                get { return RequiredElement != null ? RequiredElement.Value : null; }
                set
                {
                    if(value == null)
                      RequiredElement = null; 
                    else
                      RequiredElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Required");
                }
            }
            
            /// <summary>
            /// Whether the group may repeat
            /// </summary>
            [FhirElement("repeats", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean RepeatsElement
            {
                get { return _RepeatsElement; }
                set { _RepeatsElement = value; OnPropertyChanged("RepeatsElement"); }
            }
            private Hl7.Fhir.Model.FhirBoolean _RepeatsElement;
            
            /// <summary>
            /// Whether the group may repeat
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Repeats
            {
                get { return RepeatsElement != null ? RepeatsElement.Value : null; }
                set
                {
                    if(value == null)
                      RepeatsElement = null; 
                    else
                      RepeatsElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Repeats");
                }
            }
            
            /// <summary>
            /// Nested questionnaire group
            /// </summary>
            [FhirElement("group", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Questionnaire.GroupComponent> Group
            {
                get { return _Group; }
                set { _Group = value; OnPropertyChanged("Group"); }
            }
            private List<Hl7.Fhir.Model.Questionnaire.GroupComponent> _Group;
            
            /// <summary>
            /// Questions in this group
            /// </summary>
            [FhirElement("question", InSummary=true, Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Questionnaire.QuestionComponent> Question
            {
                get { return _Question; }
                set { _Question = value; OnPropertyChanged("Question"); }
            }
            private List<Hl7.Fhir.Model.Questionnaire.QuestionComponent> _Question;
            
        }
        
        
        /// <summary>
        /// External Ids for this questionnaire
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=70)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// Logical id for this version of Questionnaire
        /// </summary>
        [FhirElement("version", InSummary=true, Order=80)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString VersionElement
        {
            get { return _VersionElement; }
            set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
        }
        private Hl7.Fhir.Model.FhirString _VersionElement;
        
        /// <summary>
        /// Logical id for this version of Questionnaire
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if(value == null)
                  VersionElement = null; 
                else
                  VersionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Version");
            }
        }
        
        /// <summary>
        /// draft | published | retired
        /// </summary>
        [FhirElement("status", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.Questionnaire.QuestionnaireStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        private Code<Hl7.Fhir.Model.Questionnaire.QuestionnaireStatus> _StatusElement;
        
        /// <summary>
        /// draft | published | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.Questionnaire.QuestionnaireStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.Questionnaire.QuestionnaireStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Date this version was authored
        /// </summary>
        [FhirElement("date", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.Date DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        private Hl7.Fhir.Model.Date _DateElement;
        
        /// <summary>
        /// Date this version was authored
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
                  DateElement = new Hl7.Fhir.Model.Date(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Organization who designed the questionnaire
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PublisherElement
        {
            get { return _PublisherElement; }
            set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
        }
        private Hl7.Fhir.Model.FhirString _PublisherElement;
        
        /// <summary>
        /// Organization who designed the questionnaire
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if(value == null)
                  PublisherElement = null; 
                else
                  PublisherElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }
        
        /// <summary>
        /// Grouped questions
        /// </summary>
        [FhirElement("group", Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Questionnaire.GroupComponent Group
        {
            get { return _Group; }
            set { _Group = value; OnPropertyChanged("Group"); }
        }
        private Hl7.Fhir.Model.Questionnaire.GroupComponent _Group;
        
    }
    
}
