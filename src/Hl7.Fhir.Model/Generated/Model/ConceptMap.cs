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
    /// A statement of relationships from one set of concepts to one or more other concepts - either code systems or data elements, or classes in class models
    /// </summary>
    [FhirType("ConceptMap", IsResource=true)]
    [DataContract]
    public partial class ConceptMap : Hl7.Fhir.Model.Resource, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// The degree of equivalence between concepts
        /// </summary>
        [FhirEnumeration("ConceptMapEquivalence")]
        public enum ConceptMapEquivalence
        {
            /// <summary>
            /// The definitions of the concepts are exactly the same (i.e. only grammatical differences) and structural implications of meaning are identifical or irrelevant (i.e. intensionally identical).
            /// </summary>
            [EnumLiteral("equal")]
            Equal,
            /// <summary>
            /// The definitions of the concepts mean the same thing (including when structural implications of meaning are considered) (i.e. extensionally identical).
            /// </summary>
            [EnumLiteral("equivalent")]
            Equivalent,
            /// <summary>
            /// The target mapping is wider in meaning than the source concept.
            /// </summary>
            [EnumLiteral("wider")]
            Wider,
            /// <summary>
            /// The target mapping subsumes the meaning of the source concept (e.g. the source is-a target).
            /// </summary>
            [EnumLiteral("subsumes")]
            Subsumes,
            /// <summary>
            /// The target mapping is narrower in meaning that the source concept. The sense in which the mapping is narrower SHALL be described in the comments in this case, and applications should be careful when atempting to use these mappings operationally.
            /// </summary>
            [EnumLiteral("narrower")]
            Narrower,
            /// <summary>
            /// The target mapping specialises the meaning of the source concept (e.g. the target is-a source).
            /// </summary>
            [EnumLiteral("specialises")]
            Specialises,
            /// <summary>
            /// The target mapping overlaps with the source concept, but both source and target cover additional meaning. The sense in which the mapping is narrower SHALL be described in the comments in this case, and applications should be careful when atempting to use these mappings operationally.
            /// </summary>
            [EnumLiteral("inexact")]
            Inexact,
            /// <summary>
            /// There is no match for this concept in the destination concept system.
            /// </summary>
            [EnumLiteral("unmatched")]
            Unmatched,
            /// <summary>
            /// This is an explicit assertion that there is no mapping between the source and target concept.
            /// </summary>
            [EnumLiteral("disjoint")]
            Disjoint,
        }
        
        [FhirType("ConceptMapElementComponent")]
        [DataContract]
        public partial class ConceptMapElementComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Code System (if value set crosses code systems)
            /// </summary>
            [FhirElement("codeSystem", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri CodeSystemElement
            {
                get { return _CodeSystemElement; }
                set { _CodeSystemElement = value; OnPropertyChanged("CodeSystemElement"); }
            }
            private Hl7.Fhir.Model.FhirUri _CodeSystemElement;
            
            /// <summary>
            /// Code System (if value set crosses code systems)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public System.Uri CodeSystem
            {
                get { return CodeSystemElement != null ? CodeSystemElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeSystemElement = null; 
                    else
                      CodeSystemElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("CodeSystem");
                }
            }
            
            /// <summary>
            /// Identifies element being mapped
            /// </summary>
            [FhirElement("code", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Code CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            private Hl7.Fhir.Model.Code _CodeElement;
            
            /// <summary>
            /// Identifies element being mapped
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeElement = null; 
                    else
                      CodeElement = new Hl7.Fhir.Model.Code(value);
                    OnPropertyChanged("Code");
                }
            }
            
            /// <summary>
            /// Other elements required for this mapping (from context)
            /// </summary>
            [FhirElement("dependsOn", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ConceptMap.OtherElementComponent> DependsOn
            {
                get { return _DependsOn; }
                set { _DependsOn = value; OnPropertyChanged("DependsOn"); }
            }
            private List<Hl7.Fhir.Model.ConceptMap.OtherElementComponent> _DependsOn;
            
            /// <summary>
            /// A concept from the target value set that this concept maps to
            /// </summary>
            [FhirElement("map", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ConceptMap.ConceptMapElementMapComponent> Map
            {
                get { return _Map; }
                set { _Map = value; OnPropertyChanged("Map"); }
            }
            private List<Hl7.Fhir.Model.ConceptMap.ConceptMapElementMapComponent> _Map;
            
        }
        
        
        [FhirType("ConceptMapElementMapComponent")]
        [DataContract]
        public partial class ConceptMapElementMapComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// System of the target (if necessary)
            /// </summary>
            [FhirElement("codeSystem", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri CodeSystemElement
            {
                get { return _CodeSystemElement; }
                set { _CodeSystemElement = value; OnPropertyChanged("CodeSystemElement"); }
            }
            private Hl7.Fhir.Model.FhirUri _CodeSystemElement;
            
            /// <summary>
            /// System of the target (if necessary)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public System.Uri CodeSystem
            {
                get { return CodeSystemElement != null ? CodeSystemElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeSystemElement = null; 
                    else
                      CodeSystemElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("CodeSystem");
                }
            }
            
            /// <summary>
            /// Code that identifies the target element
            /// </summary>
            [FhirElement("code", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Code CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            private Hl7.Fhir.Model.Code _CodeElement;
            
            /// <summary>
            /// Code that identifies the target element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeElement = null; 
                    else
                      CodeElement = new Hl7.Fhir.Model.Code(value);
                    OnPropertyChanged("Code");
                }
            }
            
            /// <summary>
            /// equal | equivalent | wider | subsumes | narrower | specialises | inexact | unmatched | disjoint
            /// </summary>
            [FhirElement("equivalence", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.ConceptMap.ConceptMapEquivalence> EquivalenceElement
            {
                get { return _EquivalenceElement; }
                set { _EquivalenceElement = value; OnPropertyChanged("EquivalenceElement"); }
            }
            private Code<Hl7.Fhir.Model.ConceptMap.ConceptMapEquivalence> _EquivalenceElement;
            
            /// <summary>
            /// equal | equivalent | wider | subsumes | narrower | specialises | inexact | unmatched | disjoint
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.ConceptMap.ConceptMapEquivalence? Equivalence
            {
                get { return EquivalenceElement != null ? EquivalenceElement.Value : null; }
                set
                {
                    if(value == null)
                      EquivalenceElement = null; 
                    else
                      EquivalenceElement = new Code<Hl7.Fhir.Model.ConceptMap.ConceptMapEquivalence>(value);
                    OnPropertyChanged("Equivalence");
                }
            }
            
            /// <summary>
            /// Description of status/issues in mapping
            /// </summary>
            [FhirElement("comments", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CommentsElement
            {
                get { return _CommentsElement; }
                set { _CommentsElement = value; OnPropertyChanged("CommentsElement"); }
            }
            private Hl7.Fhir.Model.FhirString _CommentsElement;
            
            /// <summary>
            /// Description of status/issues in mapping
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
            /// Other concepts that this mapping also produces
            /// </summary>
            [FhirElement("product", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ConceptMap.OtherElementComponent> Product
            {
                get { return _Product; }
                set { _Product = value; OnPropertyChanged("Product"); }
            }
            private List<Hl7.Fhir.Model.ConceptMap.OtherElementComponent> _Product;
            
        }
        
        
        [FhirType("OtherElementComponent")]
        [DataContract]
        public partial class OtherElementComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Reference to element/field/valueset mapping depends on
            /// </summary>
            [FhirElement("element", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri ElementElement
            {
                get { return _ElementElement; }
                set { _ElementElement = value; OnPropertyChanged("ElementElement"); }
            }
            private Hl7.Fhir.Model.FhirUri _ElementElement;
            
            /// <summary>
            /// Reference to element/field/valueset mapping depends on
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public System.Uri Element
            {
                get { return ElementElement != null ? ElementElement.Value : null; }
                set
                {
                    if(value == null)
                      ElementElement = null; 
                    else
                      ElementElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("Element");
                }
            }
            
            /// <summary>
            /// Code System (if necessary)
            /// </summary>
            [FhirElement("codeSystem", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri CodeSystemElement
            {
                get { return _CodeSystemElement; }
                set { _CodeSystemElement = value; OnPropertyChanged("CodeSystemElement"); }
            }
            private Hl7.Fhir.Model.FhirUri _CodeSystemElement;
            
            /// <summary>
            /// Code System (if necessary)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public System.Uri CodeSystem
            {
                get { return CodeSystemElement != null ? CodeSystemElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeSystemElement = null; 
                    else
                      CodeSystemElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("CodeSystem");
                }
            }
            
            /// <summary>
            /// Value of the referenced element
            /// </summary>
            [FhirElement("code", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            private Hl7.Fhir.Model.FhirString _CodeElement;
            
            /// <summary>
            /// Value of the referenced element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeElement = null; 
                    else
                      CodeElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Code");
                }
            }
            
        }
        
        
        /// <summary>
        /// Logical id to reference this concept map
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
        /// Logical id to reference this concept map
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
        /// Logical id for this version of the concept map
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
        /// Logical id for this version of the concept map
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
        /// Informal name for this concept map
        /// </summary>
        [FhirElement("name", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// Informal name for this concept map
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
        /// Name of the publisher (Organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=100)]
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
        [FhirElement("telecom", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Contact> Telecom
        {
            get { return _Telecom; }
            set { _Telecom = value; OnPropertyChanged("Telecom"); }
        }
        private List<Hl7.Fhir.Model.Contact> _Telecom;
        
        /// <summary>
        /// Human language description of the concept map
        /// </summary>
        [FhirElement("description", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// Human language description of the concept map
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
        /// About the concept map or its content
        /// </summary>
        [FhirElement("copyright", Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CopyrightElement
        {
            get { return _CopyrightElement; }
            set { _CopyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }
        private Hl7.Fhir.Model.FhirString _CopyrightElement;
        
        /// <summary>
        /// About the concept map or its content
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if(value == null)
                  CopyrightElement = null; 
                else
                  CopyrightElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Copyright");
            }
        }
        
        /// <summary>
        /// draft | active | retired
        /// </summary>
        [FhirElement("status", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Code StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        private Hl7.Fhir.Model.Code _StatusElement;
        
        /// <summary>
        /// draft | active | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Hl7.Fhir.Model.Code(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ExperimentalElement
        {
            get { return _ExperimentalElement; }
            set { _ExperimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }
        private Hl7.Fhir.Model.FhirBoolean _ExperimentalElement;
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if(value == null)
                  ExperimentalElement = null; 
                else
                  ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }
        
        /// <summary>
        /// Date for given status
        /// </summary>
        [FhirElement("date", InSummary=true, Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Date for given status
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
        /// Identifies the source of the concepts which are being mapped
        /// </summary>
        [FhirElement("source", InSummary=true, Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Element Source
        {
            get { return _Source; }
            set { _Source = value; OnPropertyChanged("Source"); }
        }
        private Hl7.Fhir.Model.Element _Source;
        
        /// <summary>
        /// Provides context to the mappings
        /// </summary>
        [FhirElement("target", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Element Target
        {
            get { return _Target; }
            set { _Target = value; OnPropertyChanged("Target"); }
        }
        private Hl7.Fhir.Model.Element _Target;
        
        /// <summary>
        /// Mappings for a concept from the source set
        /// </summary>
        [FhirElement("element", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ConceptMap.ConceptMapElementComponent> Element
        {
            get { return _Element; }
            set { _Element = value; OnPropertyChanged("Element"); }
        }
        private List<Hl7.Fhir.Model.ConceptMap.ConceptMapElementComponent> _Element;
        
    }
    
}
