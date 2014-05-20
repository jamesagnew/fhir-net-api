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
    /// Resource Observation Definition
    /// </summary>
    [FhirType("CommonDataElement", IsResource=true)]
    [DataContract]
    public partial class CommonDataElement : Hl7.Fhir.Model.Resource, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// The lifecycle status of a Resource Observation Definition
        /// </summary>
        [FhirEnumeration("ResourceCommonDataElementStatus")]
        public enum ResourceCommonDataElementStatus
        {
            /// <summary>
            /// This observation definition is still under development.
            /// </summary>
            [EnumLiteral("draft")]
            Draft,
            /// <summary>
            /// This observation definition is ready for normal use.
            /// </summary>
            [EnumLiteral("active")]
            Active,
            /// <summary>
            /// This observation definition has been deprecated, withdrawn or superseded and should no longer be used.
            /// </summary>
            [EnumLiteral("retired")]
            Retired,
        }
        
        [FhirType("CommonDataElementMappingComponent")]
        [DataContract]
        public partial class CommonDataElementMappingComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Identifies what this mapping refers to
            /// </summary>
            [FhirElement("uri", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri UriElement
            {
                get { return _UriElement; }
                set { _UriElement = value; OnPropertyChanged("UriElement"); }
            }
            private Hl7.Fhir.Model.FhirUri _UriElement;
            
            /// <summary>
            /// Identifies what this mapping refers to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public System.Uri Uri
            {
                get { return UriElement != null ? UriElement.Value : null; }
                set
                {
                    if(value == null)
                      UriElement = null; 
                    else
                      UriElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("Uri");
                }
            }
            
            /// <summary>
            /// Names what this mapping refers to
            /// </summary>
            [FhirElement("name", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Names what this mapping refers to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Versions, Issues, Scope limitations etc
            /// </summary>
            [FhirElement("comments", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CommentsElement
            {
                get { return _CommentsElement; }
                set { _CommentsElement = value; OnPropertyChanged("CommentsElement"); }
            }
            private Hl7.Fhir.Model.FhirString _CommentsElement;
            
            /// <summary>
            /// Versions, Issues, Scope limitations etc
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Comments
            {
                get { return CommentsElement != null ? CommentsElement.Value : null; }
                set
                {
                    if(value == null)
                      CommentsElement = null; 
                    else
                      CommentsElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Comments");
                }
            }
            
            /// <summary>
            /// Details of the mapping
            /// </summary>
            [FhirElement("map", InSummary=true, Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MapElement
            {
                get { return _MapElement; }
                set { _MapElement = value; OnPropertyChanged("MapElement"); }
            }
            private Hl7.Fhir.Model.FhirString _MapElement;
            
            /// <summary>
            /// Details of the mapping
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Map
            {
                get { return MapElement != null ? MapElement.Value : null; }
                set
                {
                    if(value == null)
                      MapElement = null; 
                    else
                      MapElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Map");
                }
            }
            
        }
        
        
        [FhirType("CommonDataElementBindingComponent")]
        [DataContract]
        public partial class CommonDataElementBindingComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Can additional codes be used?
            /// </summary>
            [FhirElement("isExtensible", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean IsExtensibleElement
            {
                get { return _IsExtensibleElement; }
                set { _IsExtensibleElement = value; OnPropertyChanged("IsExtensibleElement"); }
            }
            private Hl7.Fhir.Model.FhirBoolean _IsExtensibleElement;
            
            /// <summary>
            /// Can additional codes be used?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? IsExtensible
            {
                get { return IsExtensibleElement != null ? IsExtensibleElement.Value : null; }
                set
                {
                    if(value == null)
                      IsExtensibleElement = null; 
                    else
                      IsExtensibleElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("IsExtensible");
                }
            }
            
            /// <summary>
            /// required | preferred | example
            /// </summary>
            [FhirElement("conformance", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Code ConformanceElement
            {
                get { return _ConformanceElement; }
                set { _ConformanceElement = value; OnPropertyChanged("ConformanceElement"); }
            }
            private Hl7.Fhir.Model.Code _ConformanceElement;
            
            /// <summary>
            /// required | preferred | example
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Conformance
            {
                get { return ConformanceElement != null ? ConformanceElement.Value : null; }
                set
                {
                    if(value == null)
                      ConformanceElement = null; 
                    else
                      ConformanceElement = new Hl7.Fhir.Model.Code(value);
                    OnPropertyChanged("Conformance");
                }
            }
            
            /// <summary>
            /// Human explanation of the value set
            /// </summary>
            [FhirElement("description", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Human explanation of the value set
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if(value == null)
                      DescriptionElement = null; 
                    else
                      DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// Source of value set
            /// </summary>
            [FhirElement("reference", InSummary=true, Order=70)]
            [References("ValueSet")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Reference
            {
                get { return _Reference; }
                set { _Reference = value; OnPropertyChanged("Reference"); }
            }
            private Hl7.Fhir.Model.ResourceReference _Reference;
            
        }
        
        
        /// <summary>
        /// Logical id to reference this profile
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=70)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString IdentifierElement
        {
            get { return _IdentifierElement; }
            set { _IdentifierElement = value; OnPropertyChanged("IdentifierElement"); }
        }
        private Hl7.Fhir.Model.FhirString _IdentifierElement;
        
        /// <summary>
        /// Logical id to reference this profile
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Identifier
        {
            get { return IdentifierElement != null ? IdentifierElement.Value : null; }
            set
            {
                if(value == null)
                  IdentifierElement = null; 
                else
                  IdentifierElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Identifier");
            }
        }
        
        /// <summary>
        /// Logical id for this version of the profile
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
        /// Logical id for this version of the profile
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
        /// Name of the publisher (Organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=90)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PublisherElement
        {
            get { return _PublisherElement; }
            set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
        }
        private Hl7.Fhir.Model.FhirString _PublisherElement;
        
        /// <summary>
        /// Name of the publisher (Organization or individual)
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
        /// Contact information of the publisher
        /// </summary>
        [FhirElement("telecom", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Contact> Telecom
        {
            get { return _Telecom; }
            set { _Telecom = value; OnPropertyChanged("Telecom"); }
        }
        private List<Hl7.Fhir.Model.Contact> _Telecom;
        
        /// <summary>
        /// draft | active | retired
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.CommonDataElement.ResourceCommonDataElementStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        private Code<Hl7.Fhir.Model.CommonDataElement.ResourceCommonDataElementStatus> _StatusElement;
        
        /// <summary>
        /// draft | active | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.CommonDataElement.ResourceCommonDataElementStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.CommonDataElement.ResourceCommonDataElementStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Date for this version of the observation definition
        /// </summary>
        [FhirElement("date", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Date for this version of the observation definition
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
        /// Descriptive label for this element definition
        /// </summary>
        [FhirElement("name", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// Descriptive label for this element definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if(value == null)
                  NameElement = null; 
                else
                  NameElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Name");
            }
        }
        
        /// <summary>
        /// Assist with indexing and finding
        /// </summary>
        [FhirElement("category", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Category
        {
            get { return _Category; }
            set { _Category = value; OnPropertyChanged("Category"); }
        }
        private List<Hl7.Fhir.Model.CodeableConcept> _Category;
        
        /// <summary>
        /// Identifying concept
        /// </summary>
        [FhirElement("code", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Coding> Code
        {
            get { return _Code; }
            set { _Code = value; OnPropertyChanged("Code"); }
        }
        private List<Hl7.Fhir.Model.Coding> _Code;
        
        /// <summary>
        /// How to ask for element
        /// </summary>
        [FhirElement("question", InSummary=true, Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString QuestionElement
        {
            get { return _QuestionElement; }
            set { _QuestionElement = value; OnPropertyChanged("QuestionElement"); }
        }
        private Hl7.Fhir.Model.FhirString _QuestionElement;
        
        /// <summary>
        /// How to ask for element
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Question
        {
            get { return QuestionElement != null ? QuestionElement.Value : null; }
            set
            {
                if(value == null)
                  QuestionElement = null; 
                else
                  QuestionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Question");
            }
        }
        
        /// <summary>
        /// Full formal definition in human language
        /// </summary>
        [FhirElement("definition", Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DefinitionElement
        {
            get { return _DefinitionElement; }
            set { _DefinitionElement = value; OnPropertyChanged("DefinitionElement"); }
        }
        private Hl7.Fhir.Model.FhirString _DefinitionElement;
        
        /// <summary>
        /// Full formal definition in human language
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Definition
        {
            get { return DefinitionElement != null ? DefinitionElement.Value : null; }
            set
            {
                if(value == null)
                  DefinitionElement = null; 
                else
                  DefinitionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Definition");
            }
        }
        
        /// <summary>
        /// Comments about the use of this element
        /// </summary>
        [FhirElement("comments", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CommentsElement
        {
            get { return _CommentsElement; }
            set { _CommentsElement = value; OnPropertyChanged("CommentsElement"); }
        }
        private Hl7.Fhir.Model.FhirString _CommentsElement;
        
        /// <summary>
        /// Comments about the use of this element
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Comments
        {
            get { return CommentsElement != null ? CommentsElement.Value : null; }
            set
            {
                if(value == null)
                  CommentsElement = null; 
                else
                  CommentsElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Comments");
            }
        }
        
        /// <summary>
        /// Why is this needed?
        /// </summary>
        [FhirElement("requirements", Order=190)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString RequirementsElement
        {
            get { return _RequirementsElement; }
            set { _RequirementsElement = value; OnPropertyChanged("RequirementsElement"); }
        }
        private Hl7.Fhir.Model.FhirString _RequirementsElement;
        
        /// <summary>
        /// Why is this needed?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Requirements
        {
            get { return RequirementsElement != null ? RequirementsElement.Value : null; }
            set
            {
                if(value == null)
                  RequirementsElement = null; 
                else
                  RequirementsElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Requirements");
            }
        }
        
        /// <summary>
        /// Other names
        /// </summary>
        [FhirElement("synonym", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirString> SynonymElement
        {
            get { return _SynonymElement; }
            set { _SynonymElement = value; OnPropertyChanged("SynonymElement"); }
        }
        private List<Hl7.Fhir.Model.FhirString> _SynonymElement;
        
        /// <summary>
        /// Other names
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> Synonym
        {
            get { return SynonymElement != null ? SynonymElement.Select(elem => elem.Value) : null; }
            set
            {
                if(value == null)
                  SynonymElement = null; 
                else
                  SynonymElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                OnPropertyChanged("Synonym");
            }
        }
        
        /// <summary>
        /// Name of Data type
        /// </summary>
        [FhirElement("type", Order=210)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Code TypeElement
        {
            get { return _TypeElement; }
            set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
        }
        private Hl7.Fhir.Model.Code _TypeElement;
        
        /// <summary>
        /// Name of Data type
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if(value == null)
                  TypeElement = null; 
                else
                  TypeElement = new Hl7.Fhir.Model.Code(value);
                OnPropertyChanged("Type");
            }
        }
        
        /// <summary>
        /// Example value: [as defined for type]
        /// </summary>
        [FhirElement("example", Order=220, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.Element))]
        [DataMember]
        public Hl7.Fhir.Model.Element Example
        {
            get { return _Example; }
            set { _Example = value; OnPropertyChanged("Example"); }
        }
        private Hl7.Fhir.Model.Element _Example;
        
        /// <summary>
        /// Length for strings
        /// </summary>
        [FhirElement("maxLength", Order=230)]
        [DataMember]
        public Hl7.Fhir.Model.Integer MaxLengthElement
        {
            get { return _MaxLengthElement; }
            set { _MaxLengthElement = value; OnPropertyChanged("MaxLengthElement"); }
        }
        private Hl7.Fhir.Model.Integer _MaxLengthElement;
        
        /// <summary>
        /// Length for strings
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? MaxLength
        {
            get { return MaxLengthElement != null ? MaxLengthElement.Value : null; }
            set
            {
                if(value == null)
                  MaxLengthElement = null; 
                else
                  MaxLengthElement = new Hl7.Fhir.Model.Integer(value);
                OnPropertyChanged("MaxLength");
            }
        }
        
        /// <summary>
        /// Units to use for measured value
        /// </summary>
        [FhirElement("units", Order=240)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Units
        {
            get { return _Units; }
            set { _Units = value; OnPropertyChanged("Units"); }
        }
        private Hl7.Fhir.Model.CodeableConcept _Units;
        
        /// <summary>
        /// ValueSet details if this is coded
        /// </summary>
        [FhirElement("binding", Order=250)]
        [DataMember]
        public Hl7.Fhir.Model.CommonDataElement.CommonDataElementBindingComponent Binding
        {
            get { return _Binding; }
            set { _Binding = value; OnPropertyChanged("Binding"); }
        }
        private Hl7.Fhir.Model.CommonDataElement.CommonDataElementBindingComponent _Binding;
        
        /// <summary>
        /// Map element to another set of definitions
        /// </summary>
        [FhirElement("mapping", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CommonDataElement.CommonDataElementMappingComponent> Mapping
        {
            get { return _Mapping; }
            set { _Mapping = value; OnPropertyChanged("Mapping"); }
        }
        private List<Hl7.Fhir.Model.CommonDataElement.CommonDataElementMappingComponent> _Mapping;
        
    }
    
}
