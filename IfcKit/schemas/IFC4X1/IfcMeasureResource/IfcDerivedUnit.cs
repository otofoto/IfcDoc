// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace BuildingSmart.IFC.IfcMeasureResource
{
	[Guid("e85ff2ff-6c6c-4a78-9fb0-28988abecbf3")]
	public partial class IfcDerivedUnit :
		BuildingSmart.IFC.IfcMeasureResource.IfcUnit
	{
		[DataMember(Order=0)] 
		[Required()]
		ISet<IfcDerivedUnitElement> _Elements = new HashSet<IfcDerivedUnitElement>();
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcDerivedUnitEnum _UnitType;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcLabel? _UserDefinedType;
	
	
		[Description("The group of units and their exponents that define the derived unit.")]
		public ISet<IfcDerivedUnitElement> Elements { get { return this._Elements; } }
	
		[Description("Name of the derived unit chosen from an enumeration of derived unit types for use" +
	    " in IFC models.")]
		public IfcDerivedUnitEnum UnitType { get { return this._UnitType; } set { this._UnitType = value;} }
	
		public IfcLabel? UserDefinedType { get { return this._UserDefinedType; } set { this._UserDefinedType = value;} }
	
		public new IfcDimensionalExponents Dimensions { get { return null; } }
	
	
	}
	
}