﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
public partial class item {
    
    private itemIdMode idModeField;
    
    private string qtyField;
    
    private string keyField;
    
    private float singleTimeField;
    
    private bool singleTimeFieldSpecified;
    
    private float setupTimeField;
    
    private bool setupTimeFieldSpecified;
    
    private float calcTimeField;
    
    private bool calcTimeFieldSpecified;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public itemIdMode idMode {
        get {
            return this.idModeField;
        }
        set {
            this.idModeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
    public string qty {
        get {
            return this.qtyField;
        }
        set {
            this.qtyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string key {
        get {
            return this.keyField;
        }
        set {
            this.keyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float singleTime {
        get {
            return this.singleTimeField;
        }
        set {
            this.singleTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool singleTimeSpecified {
        get {
            return this.singleTimeFieldSpecified;
        }
        set {
            this.singleTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float setupTime {
        get {
            return this.setupTimeField;
        }
        set {
            this.setupTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool setupTimeSpecified {
        get {
            return this.setupTimeFieldSpecified;
        }
        set {
            this.setupTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float calcTime {
        get {
            return this.calcTimeField;
        }
        set {
            this.calcTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool calcTimeSpecified {
        get {
            return this.calcTimeFieldSpecified;
        }
        set {
            this.calcTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum itemIdMode {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CMkSchema {
    
    private item[][] kalkulationSchrankField;
    
    private item[][] kalkulationKastenField;
    
    private item[][] kalkulationPultField;
    
    private string versionField;
    
    private string ppnrField;
    
    private string sdField;
    
    private string teamField;
    
    private string amountField;
    
    private decimal quantitativeFactorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("item", typeof(item))]
    public item[][] KalkulationSchrank {
        get {
            return this.kalkulationSchrankField;
        }
        set {
            this.kalkulationSchrankField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("item", typeof(item))]
    public item[][] KalkulationKasten {
        get {
            return this.kalkulationKastenField;
        }
        set {
            this.kalkulationKastenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("item", typeof(item))]
    public item[][] KalkulationPult {
        get {
            return this.kalkulationPultField;
        }
        set {
            this.kalkulationPultField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ppnr {
        get {
            return this.ppnrField;
        }
        set {
            this.ppnrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sd {
        get {
            return this.sdField;
        }
        set {
            this.sdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string team {
        get {
            return this.teamField;
        }
        set {
            this.teamField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
    public string amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal quantitativeFactor {
        get {
            return this.quantitativeFactorField;
        }
        set {
            this.quantitativeFactorField = value;
        }
    }
}