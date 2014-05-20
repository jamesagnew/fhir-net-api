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
    /// A structured set of questions and their answers
    /// </summary>
    [FhirType("QuestionnaireAnswers", IsResource=true)]
    [DataContract]
    public partial class QuestionnaireAnswers : Hl7.Fhir.Model.Resource, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Lifecycle status of the questionnaire answers
        /// </summary>
        [FhirEnumeration("QuestionnaireAnswersStatus")]
        public enum QuestionnaireAnswersStatus
        {
            /// <summary>
            /// This QuestionnaireAnswers has been partially filled out with answers, but changes or additions are still expected to be made to it.
            /// </summary>
            [EnumLiteral("in progress")]
            InProgress,
            /// <summary>
            /// This QuestionnaireAnswers has been filled out with answers, and the current content is regarded as definitive.
            /// </summary>
            [EnumLiteral("completed")]
            Completed,
            /// <summary>
            /// This QuestionnaireAnswers has been filled out with answers, then marked as complete, yet changes or additions have been made to it afterwards.
            /// </summary>
            [EnumLiteral("amended")]
            Amended,
        }
        
        [FhirType("QuestionAnswerComponent")]
        [DataContract]
        public partial class QuestionAnswerComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Single-valued answer to the question
            /// </summary>
            [FhirElement("value", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDecimal),typeof(Hl7.Fhir.Model.Integer),typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.Date),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Instant),typeof(Hl7.Fhir.Model.Coding))]
            [DataMember]
            public Hl7.Fhir.Model.Element Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }
            private Hl7.Fhir.Model.Element _Value;
            
        }
        
        
        [FhirType("QuestionComponent")]
        [DataContract]
        public partial class QuestionComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Corresponding question within Questionnaire
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
            /// Corresponding question within Questionnaire
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
            /// Text of the question as it is shown to the user
            /// </summary>
            [FhirElement("text", InSummary=true, Order=50)]
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
            /// The response(s) to the question
            /// </summary>
            [FhirElement("answer", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.QuestionnaireAnswers.QuestionAnswerComponent> Answer
            {
                get { return _Answer; }
                set { _Answer = value; OnPropertyChanged("Answer"); }
            }
            private List<Hl7.Fhir.Model.QuestionnaireAnswers.QuestionAnswerComponent> _Answer;
            
            /// <summary>
            /// Nested questionnaire group
            /// </summary>
            [FhirElement("group", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.QuestionnaireAnswers.GroupComponent> Group
            {
                get { return _Group; }
                set { _Group = value; OnPropertyChanged("Group"); }
            }
            private List<Hl7.Fhir.Model.QuestionnaireAnswers.GroupComponent> _Group;
            
        }
        
        
        [FhirType("GroupComponent")]
        [DataContract]
        public partial class GroupComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Corresponding group within Questionnaire
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
            /// Corresponding group within Questionnaire
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
            /// Name for this group
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
            /// Name for this group
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
            /// Additional text for the group
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
            /// The subject this group's answers are about
            /// </summary>
            [FhirElement("subject", InSummary=true, Order=70)]
            [References()]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Subject
            {
                get { return _Subject; }
                set { _Subject = value; OnPropertyChanged("Subject"); }
            }
            private Hl7.Fhir.Model.ResourceReference _Subject;
            
            /// <summary>
            /// Nested questionnaire answers group
            /// </summary>
            [FhirElement("group", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.QuestionnaireAnswers.GroupComponent> Group
            {
                get { return _Group; }
                set { _Group = value; OnPropertyChanged("Group"); }
            }
            private List<Hl7.Fhir.Model.QuestionnaireAnswers.GroupComponent> _Group;
            
            /// <summary>
            /// Questions in this group
            /// </summary>
            [FhirElement("question", InSummary=true, Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.QuestionnaireAnswers.QuestionComponent> Question
            {
                get { return _Question; }
                set { _Question = value; OnPropertyChanged("Question"); }
            }
            private List<Hl7.Fhir.Model.QuestionnaireAnswers.QuestionComponent> _Question;
            
        }
        
        
        /// <summary>
        /// Form being answered
        /// </summary>
        [FhirElement("questionnaire", Order=70)]
        [References("Questionnaire")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Questionnaire
        {
            get { return _Questionnaire; }
            set { _Questionnaire = value; OnPropertyChanged("Questionnaire"); }
        }
        private Hl7.Fhir.Model.ResourceReference _Questionnaire;
        
        /// <summary>
        /// in progress | completed | amended
        /// </summary>
        [FhirElement("status", InSummary=true, Order=80)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.QuestionnaireAnswers.QuestionnaireAnswersStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        private Code<Hl7.Fhir.Model.QuestionnaireAnswers.QuestionnaireAnswersStatus> _StatusElement;
        
        /// <summary>
        /// in progress | completed | amended
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.QuestionnaireAnswers.QuestionnaireAnswersStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.QuestionnaireAnswers.QuestionnaireAnswersStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// The subject of the questions
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=90)]
        [References()]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        private Hl7.Fhir.Model.ResourceReference _Subject;
        
        /// <summary>
        /// Person who received and recorded the answers
        /// </summary>
        [FhirElement("author", InSummary=true, Order=100)]
        [References("Practitioner","Patient","RelatedPerson")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Author
        {
            get { return _Author; }
            set { _Author = value; OnPropertyChanged("Author"); }
        }
        private Hl7.Fhir.Model.ResourceReference _Author;
        
        /// <summary>
        /// Date this version was authored
        /// </summary>
        [FhirElement("authored", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime AuthoredElement
        {
            get { return _AuthoredElement; }
            set { _AuthoredElement = value; OnPropertyChanged("AuthoredElement"); }
        }
        private Hl7.Fhir.Model.FhirDateTime _AuthoredElement;
        
        /// <summary>
        /// Date this version was authored
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Authored
        {
            get { return AuthoredElement != null ? AuthoredElement.Value : null; }
            set
            {
                if(value == null)
                  AuthoredElement = null; 
                else
                  AuthoredElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Authored");
            }
        }
        
        /// <summary>
        /// The person who answered the questions
        /// </summary>
        [FhirElement("source", InSummary=true, Order=120)]
        [References("Patient","Practitioner","RelatedPerson")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Source
        {
            get { return _Source; }
            set { _Source = value; OnPropertyChanged("Source"); }
        }
        private Hl7.Fhir.Model.ResourceReference _Source;
        
        /// <summary>
        /// Primary encounter during which the answers were collected
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=130)]
        [References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        private Hl7.Fhir.Model.ResourceReference _Encounter;
        
        /// <summary>
        /// Grouped questions
        /// </summary>
        [FhirElement("group", Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.QuestionnaireAnswers.GroupComponent Group
        {
            get { return _Group; }
            set { _Group = value; OnPropertyChanged("Group"); }
        }
        private Hl7.Fhir.Model.QuestionnaireAnswers.GroupComponent _Group;
        
    }
    
}
