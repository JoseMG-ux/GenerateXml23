using System;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://dgi-fep.mef.gob.pa")]
public partial class rEnviFe
{
    private string dVerFormField;
    private string dIdField;
    private int iAmbField;
    private xFe xFeField;

    /// <remarks/>
    public string dVerForm
    {
        get { return this.dVerFormField; }
        set { this.dVerFormField = value; }
    }

    /// <remarks/>
    public string dId
    {
        get { return this.dIdField; }
        set { this.dIdField = value; }
    }

    /// <remarks/>
    public int iAmb
    {
        get { return this.iAmbField; }
        set { this.iAmbField = value; }
    }

    // <remarks/>
    public xFe xFe
    {
        get { return this.xFeField; }
        set { this.xFeField = value; }
    }
}

/// <remarks/>
//[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//[XmlRoot(Namespace = "http://dgi-fep.mef.gob.pa")]
public partial class xFe
{
    private rFE rFEField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://dgi-fep.mef.gob.pa")]
    public rFE rFE
    {
        get { return this.rFEField; }
        set { this.rFEField = value; }
    }
}

/// <remarks/>
//[System.SerializableAttribute()]
////[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://dgi-fep.mef.gob.pa")]
//[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://dgi-fep.mef.gob.pa")]
[Serializable]
[XmlRoot(ElementName = "rFE", Namespace = "http://dgi-fep.mef.gob.pa")]
public partial class rFE //: IXmlSerializable
{
    private string dVerFormField;

    private string dIdField;

    private rFEGDGen? gDGenField;

    private rFEGItem[]? gItemField;

    private rFEGTot gTotField;

    private rFEGPedComGl? gPedComGlField;

    private rFEGInfoLog? gInfoLogField;

    private rFEGLcEntr? gLcEntrField;

    private Signature? signatureField;

    private rFEGNoFirm? gNoFirmField;

    /// <remarks/>
    public string dVerForm
    {
        get { return this.dVerFormField; }
        set { this.dVerFormField = value; }
    }

    /// <remarks/>
    public string dId
    {
        get { return this.dIdField; }
        set { this.dIdField = value; }
    }

    /// <remarks/>
    public rFEGDGen gDGen
    {
        get { return this.gDGenField; }
        set { this.gDGenField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("gItem")]
    public rFEGItem[] gItem
    {
        get { return this.gItemField; }
        set { this.gItemField = value; }
    }

    // <remarks/>
    public rFEGTot gTot
    {
        get { return this.gTotField; }
        set { this.gTotField = value; }
    }

    /// <remarks/>
    public rFEGPedComGl? gPedComGl
    {
        get { return this.gPedComGlField; }
        set { this.gPedComGlField = value; }
    }

    /// <remarks/>
    public rFEGInfoLog? gInfoLog
    {
        get { return this.gInfoLogField; }
        set { this.gInfoLogField = value; }
    }

    /// <remarks/>
    public rFEGLcEntr? gLcEntr
    {
        get { return this.gLcEntrField; }
        set { this.gLcEntrField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public Signature Signature
    {
        get { return this.signatureField; }
        set { this.signatureField = value; }
    }

    /// <remarks/>
    public rFEGNoFirm gNoFirm
    {
        get { return this.gNoFirmField; }
        set { this.gNoFirmField = value; }
    }

    public XmlSchema GetSchema()
    {
        return null;
    }

    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGDGen
{
    private int iAmbField;

    private string iTpEmisField;

    private string? dFechaContField;

    private string? dMotContField;

    private string iDocField;

    private string dNroDFField;

    private string dPtoFacDFField;

    private int dSegField;

    private string dFechaEmField;

    private string? dFechaSalidaField;

    private string iNatOpField;

    private int iTipoOpField;

    private int iDestField;

    private int iFormCAFEField;

    private int iEntCAFEField;

    private int dEnvFEField;

    private int iProGenField;

    private string? iTipoTranVentaField;

    private string? iTipoSucField;

    private string? dInfEmFEField;

    private rFEGDGenGEmis gEmisField;

    private rFEGDGenGDatRec? gDatRecField;

    private gFExpType? gFExpField;

    private gDFRefType[]? gDFRefField;

    private rFEGDGenGAutXML[]? gAutXMLField;

    /// <remarks/>
    public int iAmb
    {
        get { return this.iAmbField; }
        set { this.iAmbField = value; }
    }

    /// <remarks/>
    public string iTpEmis
    {
        get { return this.iTpEmisField; }
        set { this.iTpEmisField = value; }
    }

    /// <remarks/>
    public string? dFechaCont
    {
        get { return this.dFechaContField; }
        set { this.dFechaContField = value; }
    }

    /// <remarks/>
    public string? dMotCont
    {
        get { return this.dMotContField; }
        set { this.dMotContField = value; }
    }

    /// <remarks/>
    public string iDoc
    {
        get { return this.iDocField; }
        set { this.iDocField = value; }
    }

    /// <remarks/>
    public string dNroDF
    {
        get { return this.dNroDFField; }
        set { this.dNroDFField = value; }
    }

    /// <remarks/>
    public string dPtoFacDF
    {
        get { return this.dPtoFacDFField; }
        set { this.dPtoFacDFField = value; }
    }

    /// <remarks/>
    public int dSeg
    {
        get { return this.dSegField; }
        set { this.dSegField = value; }
    }

    /// <remarks/>
    public string dFechaEm
    {
        get { return this.dFechaEmField; }
        set { this.dFechaEmField = value; }
    }

    /// <remarks/>
    public string? dFechaSalida
    {
        get { return this.dFechaSalidaField; }
        set { this.dFechaSalidaField = value; }
    }

    /// <remarks/>
    public string iNatOp
    {
        get { return this.iNatOpField; }
        set { this.iNatOpField = value; }
    }

    /// <remarks/>
    public int iTipoOp
    {
        get { return this.iTipoOpField; }
        set { this.iTipoOpField = value; }
    }

    /// <remarks/>
    public int iDest
    {
        get { return this.iDestField; }
        set { this.iDestField = value; }
    }

    /// <remarks/>
    public int iFormCAFE
    {
        get { return this.iFormCAFEField; }
        set { this.iFormCAFEField = value; }
    }

    /// <remarks/>
    public int iEntCAFE
    {
        get { return this.iEntCAFEField; }
        set { this.iEntCAFEField = value; }
    }

    /// <remarks/>
    public int dEnvFE
    {
        get { return this.dEnvFEField; }
        set { this.dEnvFEField = value; }
    }

    /// <remarks/>
    public int iProGen
    {
        get { return this.iProGenField; }
        set { this.iProGenField = value; }
    }

    /// <remarks/>
    public string? iTipoTranVenta
    {
        get { return this.iTipoTranVentaField; }
        set { this.iTipoTranVentaField = value; }
    }

    /// <remarks/>
    public string? iTipoSuc
    {
        get { return this.iTipoSucField; }
        set { this.iTipoSucField = value; }
    }

    /// <remarks/>
    public string? dInfEmFE
    {
        get { return this.dInfEmFEField; }
        set { this.dInfEmFEField = value; }
    }

    /// <remarks/>
    public rFEGDGenGEmis gEmis
    {
        get { return this.gEmisField; }
        set { this.gEmisField = value; }
    }

    /// <remarks/>
    public rFEGDGenGDatRec? gDatRec
    {
        get { return this.gDatRecField; }
        set { this.gDatRecField = value; }
    }

    /// <remarks/>
    public gFExpType? gFExp
    {
        get { return this.gFExpField; }
        set { this.gFExpField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("gDFRef")]
    public gDFRefType[]? gDFRef
    {
        get { return this.gDFRefField; }
        set { this.gDFRefField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("gAutXML")]
    public rFEGDGenGAutXML[]? gAutXML
    {
        get { return this.gAutXMLField; }
        set { this.gAutXMLField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class gDFRefType
{
    private rFEGDGenGEmisGRucEmi gRucEmDFRefField;

    private string dNombEmRefField;

    private string dFechaDFRefField;

    private gDFRefTypeGDFRefNum gDFRefNumField;

    /// <remarks/>
    public rFEGDGenGEmisGRucEmi gRucEmDFRef
    {
        get { return this.gRucEmDFRefField; }
        set { this.gRucEmDFRefField = value; }
    }

    /// <remarks/>
    public string dNombEmRef
    {
        get { return this.dNombEmRefField; }
        set { this.dNombEmRefField = value; }
    }

    /// <remarks/>
    public string dFechaDFRef
    {
        get { return this.dFechaDFRefField; }
        set { this.dFechaDFRefField = value; }
    }

    /// <remarks/>
    public gDFRefTypeGDFRefNum gDFRefNum
    {
        get { return this.gDFRefNumField; }
        set { this.gDFRefNumField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class gDFRefTypeGDFRefNum
{
        #region Private fields
    private object _item;
        #endregion

    [System.Xml.Serialization.XmlElementAttribute("gDFRefFE", typeof(gDFRefFE))]
    [System.Xml.Serialization.XmlElementAttribute("gDFRefFacIE", typeof(gDFRefFacIE))]
    [System.Xml.Serialization.XmlElementAttribute("gDFRefFacPap", typeof(gDFRefFacPap))]
    public object Item
    {
        get { return this._item; }
        set { this._item = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class gDFRefFacPap
{
        #region Private fields
    private string _dNroFacPap;
        #endregion

    public string dNroFacPap
    {
        get { return this._dNroFacPap; }
        set { this._dNroFacPap = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class gDFRefFacIE
{
        #region Private fields
    private string _dNroFacIE;
        #endregion

    public string dNroFacIE
    {
        get { return this._dNroFacIE; }
        set { this._dNroFacIE = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class gDFRefFE
{
        #region Private fields
    private string _dCUFERef;
        #endregion
    public string dCUFERef
    {
        get { return this._dCUFERef; }
        set { this._dCUFERef = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class gFExpType
{
    private string cCondEntrField;

    private string? cMonedaField;

    private string? cMonedaDescField;

    private string? dCambioField;

    private string? dVTotEstField;

    private string? dPuertoEmbarqField;

    /// <remarks/>
    public string cCondEntr
    {
        get { return this.cCondEntrField; }
        set { this.cCondEntrField = value; }
    }

    /// <remarks/>
    public string? cMoneda
    {
        get { return this.cMonedaField; }
        set { this.cMonedaField = value; }
    }

    /// <remarks/>
    public string? cMonedaDesc
    {
        get { return this.cMonedaDescField; }
        set { this.cMonedaDescField = value; }
    }

    /// <remarks/>
    public string? dCambio
    {
        get { return this.dCambioField; }
        set { this.dCambioField = value; }
    }

    /// <remarks/>
    public string? dVTotEst
    {
        get { return this.dVTotEstField; }
        set { this.dVTotEstField = value; }
    }

    /// <remarks/>
    public string? dPuertoEmbarq
    {
        get { return this.dPuertoEmbarqField; }
        set { this.dPuertoEmbarqField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGDGenGEmis
{
    private rFEGDGenGEmisGRucEmi gRucEmiField;

    private string dNombEmField;

    private string dSucEmField;

    private string dCoordEmField;

    private string dDirecEmField;

    private rFEGDGenGEmisGUbiEm gUbiEmField;

    private string dTfnEmField;

    private string dCorElectEmiField;

    /// <remarks/>
    public rFEGDGenGEmisGRucEmi gRucEmi
    {
        get { return this.gRucEmiField; }
        set { this.gRucEmiField = value; }
    }

    /// <remarks/>
    public string dNombEm
    {
        get { return this.dNombEmField; }
        set { this.dNombEmField = value; }
    }

    /// <remarks/>
    public string dSucEm
    {
        get { return this.dSucEmField; }
        set { this.dSucEmField = value; }
    }

    /// <remarks/>
    public string dCoordEm
    {
        get { return this.dCoordEmField; }
        set { this.dCoordEmField = value; }
    }

    /// <remarks/>
    public string dDirecEm
    {
        get { return this.dDirecEmField; }
        set { this.dDirecEmField = value; }
    }

    /// <remarks/>
    public rFEGDGenGEmisGUbiEm gUbiEm
    {
        get { return this.gUbiEmField; }
        set { this.gUbiEmField = value; }
    }

    /// <remarks/>
    public string dTfnEm
    {
        get { return this.dTfnEmField; }
        set { this.dTfnEmField = value; }
    }

    /// <remarks/>
    public string dCorElectEmi
    {
        get { return this.dCorElectEmiField; }
        set { this.dCorElectEmiField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGDGenGEmisGRucEmi
{
    private int dTipoRucField;

    private string dRucField;

    private string dDVField;

    /// <remarks/>
    public int dTipoRuc
    {
        get { return this.dTipoRucField; }
        set { this.dTipoRucField = value; }
    }

    /// <remarks/>
    public string dRuc
    {
        get { return this.dRucField; }
        set { this.dRucField = value; }
    }

    /// <remarks/>
    public string dDV
    {
        get { return this.dDVField; }
        set { this.dDVField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGDGenGEmisGUbiEm
{
    private string dCodUbiField;

    private string dCorregField;

    private string dDistrField;

    private string dProvField;

    /// <remarks/>
    public string dCodUbi
    {
        get { return this.dCodUbiField; }
        set { this.dCodUbiField = value; }
    }

    /// <remarks/>
    public string dCorreg
    {
        get { return this.dCorregField; }
        set { this.dCorregField = value; }
    }

    /// <remarks/>
    public string dDistr
    {
        get { return this.dDistrField; }
        set { this.dDistrField = value; }
    }

    /// <remarks/>
    public string dProv
    {
        get { return this.dProvField; }
        set { this.dProvField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class gIdExt
{
    private string dIdExtField;

    private string? dPaisExtField;

    /// <remarks/>
    public string dIdExt
    {
        get { return this.dIdExtField; }
        set { this.dIdExtField = value; }
    }

    /// <remarks/>
    public string? dPaisExt
    {
        get { return this.dPaisExtField; }
        set { this.dPaisExtField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGDGenGDatRec
{
    private string iTipoRecField;

    private rFEGDGenGDatRecGRucRec? gRucRecField;

    private string? dNombRecField;

    private string? dDirecRecField;

    private rFEGDGenGDatRecGUbiRec? gUbiRecField;

    private gIdExt? gIdExtField;

    private string dTfnRecField;

    private string dCorElectRecField;

    private string cPaisRecField;

    private string? cPaisRecDescField;

    /// <remarks/>
    public string iTipoRec
    {
        get { return this.iTipoRecField; }
        set { this.iTipoRecField = value; }
    }

    /// <remarks/>
    public rFEGDGenGDatRecGRucRec? gRucRec
    {
        get { return this.gRucRecField; }
        set { this.gRucRecField = value; }
    }

    /// <remarks/>
    public string? dNombRec
    {
        get { return this.dNombRecField; }
        set { this.dNombRecField = value; }
    }

    /// <remarks/>
    public string? dDirecRec
    {
        get { return this.dDirecRecField; }
        set { this.dDirecRecField = value; }
    }

    /// <remarks/>
    public rFEGDGenGDatRecGUbiRec? gUbiRec
    {
        get { return this.gUbiRecField; }
        set { this.gUbiRecField = value; }
    }

    /// <remarks/>
    public gIdExt? gIdExt
    {
        get { return this.gIdExtField; }
        set { this.gIdExtField = value; }
    }

    /// <remarks/>
    public string dTfnRec
    {
        get { return this.dTfnRecField; }
        set { this.dTfnRecField = value; }
    }

    /// <remarks/>
    public string dCorElectRec
    {
        get { return this.dCorElectRecField; }
        set { this.dCorElectRecField = value; }
    }

    /// <remarks/>
    public string cPaisRec
    {
        get { return this.cPaisRecField; }
        set { this.cPaisRecField = value; }
    }

    /// <remarks/>
    public string? cPaisRecDesc
    {
        get { return this.cPaisRecDescField; }
        set { this.cPaisRecDescField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGDGenGDatRecGRucRec
{
    private int dTipoRucField;

    private string dRucField;

    private string? dDVField;

    /// <remarks/>
    public int dTipoRuc
    {
        get { return this.dTipoRucField; }
        set { this.dTipoRucField = value; }
    }

    /// <remarks/>
    public string dRuc
    {
        get { return this.dRucField; }
        set { this.dRucField = value; }
    }

    /// <remarks/>
    public string? dDV
    {
        get { return this.dDVField; }
        set { this.dDVField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGDGenGDatRecGUbiRec
{
    private string dCodUbiField;

    private string dCorregField;

    private string dDistrField;

    private string dProvField;

    /// <remarks/>
    public string dCodUbi
    {
        get { return this.dCodUbiField; }
        set { this.dCodUbiField = value; }
    }

    /// <remarks/>
    public string dCorreg
    {
        get { return this.dCorregField; }
        set { this.dCorregField = value; }
    }

    /// <remarks/>
    public string dDistr
    {
        get { return this.dDistrField; }
        set { this.dDistrField = value; }
    }

    /// <remarks/>
    public string dProv
    {
        get { return this.dProvField; }
        set { this.dProvField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGDGenGAutXML
{
    private rFEGDGenGAutXMLGRucAutXML gRucAutXMLField;

    /// <remarks/>
    public rFEGDGenGAutXMLGRucAutXML gRucAutXML
    {
        get { return this.gRucAutXMLField; }
        set { this.gRucAutXMLField = value; }
    }
}

[Serializable]
public class gDGenTypeGAutXML { }

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGDGenGAutXMLGRucAutXML
{
    private int dTipoRucField;

    private string dRucField;

    private string dDVField;

    /// <remarks/>
    public int dTipoRuc
    {
        get { return this.dTipoRucField; }
        set { this.dTipoRucField = value; }
    }

    /// <remarks/>
    public string dRuc
    {
        get { return this.dRucField; }
        set { this.dRucField = value; }
    }

    /// <remarks/>
    public string dDV
    {
        get { return this.dDVField; }
        set { this.dDVField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGItem
{
    private string dSecItemField;

    private string dDescProdField;

    private string? dCodProdField;

    private string? cUnidadField;

    private string dCantCodIntField;

    private string? dFechaFabField;

    private string? dFechaCadField;

    private string? dCodCPBSabrField;

    private string? dCodCPBScmpField;

    private string? cUnidadCPBSField;

    private string? dInfEmFEField;

    private rFEGItemGPrecios? gPreciosField;

    private gItemTypeGCodItem? gCodItemField;

    private rFEGItemGITBMSItem? gITBMSItemField;

    private gItemTypeGISCItem? gISCItemField;

    private gItemTypeGOTIItem? gOTIItemField;

    private gVehicNuevoType? gVehicNuevoField;

    private rFEGItemGMedicina? gMedicinaField;

    private rFEGItemGPedComIr? gPedComIrField;

    /// <remarks/>
    public string dSecItem
    {
        get { return this.dSecItemField; }
        set { this.dSecItemField = value; }
    }

    /// <remarks/>
    public string dDescProd
    {
        get { return this.dDescProdField; }
        set { this.dDescProdField = value; }
    }

    /// <remarks/>
    public string? dCodProd
    {
        get { return this.dCodProdField; }
        set { this.dCodProdField = value; }
    }

    /// <remarks/>
    public string? cUnidad
    {
        get { return this.cUnidadField; }
        set { this.cUnidadField = value; }
    }

    /// <remarks/>
    public string dCantCodInt
    {
        get { return this.dCantCodIntField; }
        set { this.dCantCodIntField = value; }
    }

    /// <remarks/>
    public string? dFechaFab
    {
        get { return this.dFechaFabField; }
        set { this.dFechaFabField = value; }
    }

    /// <remarks/>
    public string? dFechaCad
    {
        get { return this.dFechaCadField; }
        set { this.dFechaCadField = value; }
    }

    /// <remarks/>
    public string? dCodCPBSabr
    {
        get { return this.dCodCPBSabrField; }
        set { this.dCodCPBSabrField = value; }
    }

    /// <remarks/>
    public string? dCodCPBScmp
    {
        get { return this.dCodCPBScmpField; }
        set { this.dCodCPBScmpField = value; }
    }

    /// <remarks/>
    public string? cUnidadCPBS
    {
        get { return this.cUnidadCPBSField; }
        set { this.cUnidadCPBSField = value; }
    }

    /// <remarks/>
    public string? dInfEmFE
    {
        get { return this.dInfEmFEField; }
        set { this.dInfEmFEField = value; }
    }

    /// <remarks/>
    public rFEGItemGPrecios? gPrecios
    {
        get { return this.gPreciosField; }
        set { this.gPreciosField = value; }
    }

    /// <remarks/>
    public gItemTypeGCodItem? gCodItem
    {
        get { return this.gCodItemField; }
        set { this.gCodItemField = value; }
    }

    /// <remarks/>
    public rFEGItemGITBMSItem? gITBMSItem
    {
        get { return this.gITBMSItemField; }
        set { this.gITBMSItemField = value; }
    }

    /// <remarks/>
    public gItemTypeGISCItem? gISCItem
    {
        get { return this.gISCItemField; }
        set { this.gISCItemField = value; }
    }

    /// <remarks/>
    public gItemTypeGOTIItem? gOTIItem
    {
        get { return this.gOTIItemField; }
        set { this.gOTIItemField = value; }
    }

    /// <remarks/>
    public gVehicNuevoType? gVehicNuevo
    {
        get { return this.gVehicNuevoField; }
        set { this.gVehicNuevoField = value; }
    }

    /// <remarks/>
    public rFEGItemGMedicina? gMedicina
    {
        get { return this.gMedicinaField; }
        set { this.gMedicinaField = value; }
    }

    /// <remarks/>
    public rFEGItemGPedComIr? gPedComIr
    {
        get { return this.gPedComIrField; }
        set { this.gPedComIrField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGItemGPrecios
{
    private string dPrUnitField;

    private string? dPrUnitDescField;

    private string dPrItemField;

    private string? dPrSegItemField;

    private string? dPrAcarItemField;

    private string dValTotItemField;

    /// <remarks/>
    public string dPrUnit
    {
        get { return this.dPrUnitField; }
        set { this.dPrUnitField = value; }
    }

    /// <remarks/>
    public string? dPrUnitDesc
    {
        get { return this.dPrUnitDescField; }
        set { this.dPrUnitDescField = value; }
    }

    /// <remarks/>
    public string dPrItem
    {
        get { return this.dPrItemField; }
        set { this.dPrItemField = value; }
    }

    /// <remarks/>
    public string? dPrAcarItem
    {
        get { return this.dPrAcarItemField; }
        set { this.dPrAcarItemField = value; }
    }

    /// <remarks/>
    public string? dPrSegItem
    {
        get { return this.dPrSegItemField; }
        set { this.dPrSegItemField = value; }
    }

    /// <remarks/>
    public string dValTotItem
    {
        get { return this.dValTotItemField; }
        set { this.dValTotItemField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGItemGITBMSItem
{
    private string dTasaITBMSField;

    private string dValITBMSField;

    /// <remarks/>
    public string dTasaITBMS
    {
        get { return this.dTasaITBMSField; }
        set { this.dTasaITBMSField = value; }
    }

    /// <remarks/>
    public string dValITBMS
    {
        get { return this.dValITBMSField; }
        set { this.dValITBMSField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class gItemTypeGCodItem
{
        #region Private fields
    private string _dGTINCom;

    private string _dCantGTINCom;

    private string _dGTINInv;

    private string _dCantComInvent;
        #endregion

    public string dGTINCom
    {
        get { return this._dGTINCom; }
        set { this._dGTINCom = value; }
    }

    public string dCantGTINCom
    {
        get { return this._dCantGTINCom; }
        set { this._dCantGTINCom = value; }
    }

    public string dGTINInv
    {
        get { return this._dGTINInv; }
        set { this._dGTINInv = value; }
    }

    public string dCantComInvent
    {
        get { return this._dCantComInvent; }
        set { this._dCantComInvent = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public class gItemTypeGOTIItem
{
        #region Private fields
    private string _dCodOTI;

    private string _dValOTI;
        #endregion

    public string dCodOTI
    {
        get { return this._dCodOTI; }
        set { this._dCodOTI = value; }
    }

    public string dValOTI
    {
        get { return this._dValOTI; }
        set { this._dValOTI = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public class gVehicNuevoType
{
        #region Private fields
    private string _iModOpVN;

    private string? _dModOpVNDesc;

    private string _dChasi;

    private string _dColorCod;

    private string? _dColorNomb;

    private string? _dPotVeh;

    private string? _dCilin;

    private string? _dPesoNet;

    private string? _dPesoBruto;

    private string _iCombust;

    private string? _dCombustDesc;

    private string _dNroMotor;

    private string? _dCapTracc;

    private string? _dEntreEj;

    private string? _dAnoMod;

    private string? _dAnoFab;

    private string? _iTipoPintura;

    private string? _dTipoPinturaDesc;

    private string _cTipoVehic;

    private string _cEspVehic;

    private string? _iCondVehic;

    private string? _dLotac;
        #endregion

    public string iModOpVN
    {
        get { return this._iModOpVN; }
        set { this._iModOpVN = value; }
    }

    public string? dModOpVNDesc
    {
        get { return this._dModOpVNDesc; }
        set { this._dModOpVNDesc = value; }
    }

    public string dChasi
    {
        get { return this._dChasi; }
        set { this._dChasi = value; }
    }

    public string dColorCod
    {
        get { return this._dColorCod; }
        set { this._dColorCod = value; }
    }

    public string? dColorNomb
    {
        get { return this._dColorNomb; }
        set { this._dColorNomb = value; }
    }

    public string? dPotVeh
    {
        get { return this._dPotVeh; }
        set { this._dPotVeh = value; }
    }

    public string? dCilin
    {
        get { return this._dCilin; }
        set { this._dCilin = value; }
    }

    public string? dPesoNet
    {
        get { return this._dPesoNet; }
        set { this._dPesoNet = value; }
    }

    public string? dPesoBruto
    {
        get { return this._dPesoBruto; }
        set { this._dPesoBruto = value; }
    }

    public string iCombust
    {
        get { return this._iCombust; }
        set { this._iCombust = value; }
    }

    public string? dCombustDesc
    {
        get { return this._dCombustDesc; }
        set { this._dCombustDesc = value; }
    }

    public string dNroMotor
    {
        get { return this._dNroMotor; }
        set { this._dNroMotor = value; }
    }

    public string? dCapTracc
    {
        get { return this._dCapTracc; }
        set { this._dCapTracc = value; }
    }

    public string? dEntreEj
    {
        get { return this._dEntreEj; }
        set { this._dEntreEj = value; }
    }

    public string? dAnoMod
    {
        get { return this._dAnoMod; }
        set { this._dAnoMod = value; }
    }

    public string? dAnoFab
    {
        get { return this._dAnoFab; }
        set { this._dAnoFab = value; }
    }

    public string? iTipoPintura
    {
        get { return this._iTipoPintura; }
        set { this._iTipoPintura = value; }
    }

    public string? dTipoPinturaDesc
    {
        get { return this._dTipoPinturaDesc; }
        set { this._dTipoPinturaDesc = value; }
    }

    public string cTipoVehic
    {
        get { return this._cTipoVehic; }
        set { this._cTipoVehic = value; }
    }

    public string cEspVehic
    {
        get { return this._cEspVehic; }
        set { this._cEspVehic = value; }
    }

    public string? iCondVehic
    {
        get { return this._iCondVehic; }
        set { this._iCondVehic = value; }
    }

    public string? dLotac
    {
        get { return this._dLotac; }
        set { this._dLotac = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGItemGMedicina
{
    private string dNroLoteField;

    private string dCtLoteField;

    /// <remarks/>
    public string dNroLote
    {
        get { return this.dNroLoteField; }
        set { this.dNroLoteField = value; }
    }

    /// <remarks/>
    public string dCtLote
    {
        get { return this.dCtLoteField; }
        set { this.dCtLoteField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public class gItemTypeGISCItem
{
        #region Private fields
    private string? _dTasaISC;

    private string _dValISC;
        #endregion

    public string? dTasaISC
    {
        get { return this._dTasaISC; }
        set { this._dTasaISC = value; }
    }

    public string dValISC
    {
        get { return this._dValISC; }
        set { this._dValISC = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGItemGPedComIr
{
    private string dNroPedField;

    private string dSecItemPedField;

    private string dInfEmPedItField;

    /// <remarks/>
    public string dNroPed
    {
        get { return this.dNroPedField; }
        set { this.dNroPedField = value; }
    }

    /// <remarks/>
    public string dSecItemPed
    {
        get { return this.dSecItemPedField; }
        set { this.dSecItemPedField = value; }
    }

    /// <remarks/>
    public string dInfEmPedIt
    {
        get { return this.dInfEmPedItField; }
        set { this.dInfEmPedItField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGTot
{
    private string dTotNetoField;

    private string dTotITBMSField;

    private string? dTotISCField;

    private string dTotGravadoField;

    private string? dTotDescField;

    private string? dTotAcarField;

    private string? dTotSegField;

    private string dVTotField;

    private string dTotRecField;

    private string? dVueltoField;

    private int iPzPagField;

    private int dNroItemsField;

    private string dVTotItemsField;

    private rFEGTotGDescBonif? gDescBonifField;

    private rFEGTotGFormaPago[]? gFormaPagoField;

    private rFEGTotGRetenc[]? gRetencField;

    private rFEGTotGPagPlazo[]? gPagPlazoField;

    private gTotTypeGOTI[]? gOTITotalField;

    /// <remarks/>
    public string dTotNeto
    {
        get { return this.dTotNetoField; }
        set { this.dTotNetoField = value; }
    }

    /// <remarks/>
    public string dTotITBMS
    {
        get { return this.dTotITBMSField; }
        set { this.dTotITBMSField = value; }
    }

    /// <remarks/>
    public string? dTotISC
    {
        get { return this.dTotISCField; }
        set { this.dTotISCField = value; }
    }

    /// <remarks/>
    public string dTotGravado
    {
        get { return this.dTotGravadoField; }
        set { this.dTotGravadoField = value; }
    }

    /// <remarks/>
    public string? dTotDesc
    {
        get { return this.dTotDescField; }
        set { this.dTotDescField = value; }
    }

    /// <remarks/>
    public string? dTotAcar
    {
        get { return this.dTotAcarField; }
        set { this.dTotAcarField = value; }
    }

    /// <remarks/>
    public string? dTotSeg
    {
        get { return this.dTotSegField; }
        set { this.dTotSegField = value; }
    }

    /// <remarks/>
    public string dVTot
    {
        get { return this.dVTotField; }
        set { this.dVTotField = value; }
    }

    /// <remarks/>
    public string dTotRec
    {
        get { return this.dTotRecField; }
        set { this.dTotRecField = value; }
    }

    /// <remarks/>
    public string? dVuelto
    {
        get { return this.dVueltoField; }
        set { this.dVueltoField = value; }
    }

    /// <remarks/>
    public int iPzPag
    {
        get { return this.iPzPagField; }
        set { this.iPzPagField = value; }
    }

    /// <remarks/>
    public int dNroItems
    {
        get { return this.dNroItemsField; }
        set { this.dNroItemsField = value; }
    }

    /// <remarks/>
    public string dVTotItems
    {
        get { return this.dVTotItemsField; }
        set { this.dVTotItemsField = value; }
    }

    /// <remarks/>
    public rFEGTotGDescBonif? gDescBonif
    {
        get { return this.gDescBonifField; }
        set { this.gDescBonifField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("gFormaPago")]
    public rFEGTotGFormaPago[]? gFormaPago
    {
        get { return this.gFormaPagoField; }
        set { this.gFormaPagoField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("gRetenc")]
    public rFEGTotGRetenc[]? gRetenc
    {
        get { return this.gRetencField; }
        set { this.gRetencField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("gPagPlazo")]
    public rFEGTotGPagPlazo[]? gPagPlazo
    {
        get { return this.gPagPlazoField; }
        set { this.gPagPlazoField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("gOTITotal")]
    public gTotTypeGOTI[]? gOTITotal
    {
        get { return this.gOTITotalField; }
        set { this.gOTITotalField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public class gTotTypeGOTI
{
    private string cCodOTITotalField;

    private string cValOTITotalField;

    /// <remarks/>
    public string dCodOTITotal
    {
        get { return this.cCodOTITotalField; }
        set { this.cCodOTITotalField = value; }
    }

    /// <remarks/>
    public string dValOTITotal
    {
        get { return this.cValOTITotalField; }
        set { this.cValOTITotalField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGTotGDescBonif
{
    private string dDetalDescField;

    private string dValDescField;

    /// <remarks/>
    public string dDetalDesc
    {
        get { return this.dDetalDescField; }
        set { this.dDetalDescField = value; }
    }

    /// <remarks/>
    public string dValDesc
    {
        get { return this.dValDescField; }
        set { this.dValDescField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGTotGFormaPago
{
    private string iFormaPagoField;

    private string? dFormaPagoDescField;

    private string dVlrCuotaField;

    /// <remarks/>
    public string iFormaPago
    {
        get { return this.iFormaPagoField; }
        set { this.iFormaPagoField = value; }
    }

    /// <remarks/>
    public string? dFormaPagoDesc
    {
        get { return this.dFormaPagoDescField; }
        set { this.dFormaPagoDescField = value; }
    }

    /// <remarks/>
    public string dVlrCuota
    {
        get { return this.dVlrCuotaField; }
        set { this.dVlrCuotaField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGTotGRetenc
{
    private string cCodRetencField;

    private string cValRetencField;

    /// <remarks/>
    public string cCodRetenc
    {
        get { return this.cCodRetencField; }
        set { this.cCodRetencField = value; }
    }

    /// <remarks/>
    public string cValRetenc
    {
        get { return this.cValRetencField; }
        set { this.cValRetencField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGTotGPagPlazo
{
    private int dSecItemField;

    private string dFecItPlazoField;

    private string dValItPlazoField;

    private string dInfPagPlazoField;

    /// <remarks/>
    public int dSecItem
    {
        get { return this.dSecItemField; }
        set { this.dSecItemField = value; }
    }

    /// <remarks/>
    public string dFecItPlazo
    {
        get { return this.dFecItPlazoField; }
        set { this.dFecItPlazoField = value; }
    }

    /// <remarks/>
    public string dValItPlazo
    {
        get { return this.dValItPlazoField; }
        set { this.dValItPlazoField = value; }
    }

    /// <remarks/>
    public string dInfPagPlazo
    {
        get { return this.dInfPagPlazoField; }
        set { this.dInfPagPlazoField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGPedComGl
{
    private string dNroPedField;

    private string dNumAceptField;

    private string? dCodRecField;

    private string? dCodSisEmField;

    private string? dInfEmPedGlField;

    /// <remarks/>
    public string dNroPed
    {
        get { return this.dNroPedField; }
        set { this.dNroPedField = value; }
    }

    /// <remarks/>
    public string dNumAcept
    {
        get { return this.dNumAceptField; }
        set { this.dNumAceptField = value; }
    }

    /// <remarks/>
    public string? dCodRec
    {
        get { return this.dCodRecField; }
        set { this.dCodRecField = value; }
    }

    /// <remarks/>
    public string? dCodSisEm
    {
        get { return this.dCodSisEmField; }
        set { this.dCodSisEmField = value; }
    }

    /// <remarks/>
    public string? dInfEmPedGl
    {
        get { return this.dInfEmPedGlField; }
        set { this.dInfEmPedGlField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGInfoLog
{
    private string? dNroVolsField;

    private string? dPesoTotField;

    private string? dUnPesoTotField;

    private string? dLicCamionField;

    private string dNomTranspField;

    private rFEGInfoLogGRucTransp gRucTranspField;

    private string? dInfEmLogField;

    /// <remarks/>
    public string? dNroVols
    {
        get { return this.dNroVolsField; }
        set { this.dNroVolsField = value; }
    }

    /// <remarks/>
    public string? dPesoTot
    {
        get { return this.dPesoTotField; }
        set { this.dPesoTotField = value; }
    }

    /// <remarks/>
    public string dUnPesoTot
    {
        get { return this.dUnPesoTotField; }
        set { this.dUnPesoTotField = value; }
    }

    /// <remarks/>
    public string dLicCamion
    {
        get { return this.dLicCamionField; }
        set { this.dLicCamionField = value; }
    }

    /// <remarks/>
    public string dNomTransp
    {
        get { return this.dNomTranspField; }
        set { this.dNomTranspField = value; }
    }

    /// <remarks/>
    public rFEGInfoLogGRucTransp gRucTransp
    {
        get { return this.gRucTranspField; }
        set { this.gRucTranspField = value; }
    }

    /// <remarks/>
    public string? dInfEmLog
    {
        get { return this.dInfEmLogField; }
        set { this.dInfEmLogField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGInfoLogGRucTransp
{
    private int dTipoRucField;

    private string dRucField;

    private string dDVField;

    /// <remarks/>
    public int dTipoRuc
    {
        get { return this.dTipoRucField; }
        set { this.dTipoRucField = value; }
    }

    /// <remarks/>
    public string dRuc
    {
        get { return this.dRucField; }
        set { this.dRucField = value; }
    }

    /// <remarks/>
    public string dDV
    {
        get { return this.dDVField; }
        set { this.dDVField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGLcEntr
{
    private rFEGLcEntrGRucLcEntr gRucLcEntrField;

    private string dNombLcEntrField;

    private string dDirecLcEntrField;

    private rFEGLcEntrGUbiLcEntr gUbiLcEntrField;

    private string? dTfnLcEntrField;

    private string? dTfnAdLcEntrField;

    /// <remarks/>
    public rFEGLcEntrGRucLcEntr gRucLcEntr
    {
        get { return this.gRucLcEntrField; }
        set { this.gRucLcEntrField = value; }
    }

    /// <remarks/>
    public string dNombLcEntr
    {
        get { return this.dNombLcEntrField; }
        set { this.dNombLcEntrField = value; }
    }

    /// <remarks/>
    public string dDirecLcEntr
    {
        get { return this.dDirecLcEntrField; }
        set { this.dDirecLcEntrField = value; }
    }

    /// <remarks/>
    public rFEGLcEntrGUbiLcEntr gUbiLcEntr
    {
        get { return this.gUbiLcEntrField; }
        set { this.gUbiLcEntrField = value; }
    }

    /// <remarks/>
    public string? dTfnLcEntr
    {
        get { return this.dTfnLcEntrField; }
        set { this.dTfnLcEntrField = value; }
    }

    /// <remarks/>
    public string? dTfnAdLcEntr
    {
        get { return this.dTfnAdLcEntrField; }
        set { this.dTfnAdLcEntrField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGLcEntrGRucLcEntr
{
    private int dTipoRucField;

    private string dRucField;

    private string dDVField;

    /// <remarks/>
    public int dTipoRuc
    {
        get { return this.dTipoRucField; }
        set { this.dTipoRucField = value; }
    }

    /// <remarks/>
    public string dRuc
    {
        get { return this.dRucField; }
        set { this.dRucField = value; }
    }

    /// <remarks/>
    public string dDV
    {
        get { return this.dDVField; }
        set { this.dDVField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGLcEntrGUbiLcEntr
{
    private string dCodUbiField;

    private string dCorregField;

    private string dDistrField;

    private string dProvField;

    /// <remarks/>
    public string dCodUbi
    {
        get { return this.dCodUbiField; }
        set { this.dCodUbiField = value; }
    }

    /// <remarks/>
    public string dCorreg
    {
        get { return this.dCorregField; }
        set { this.dCorregField = value; }
    }

    /// <remarks/>
    public string dDistr
    {
        get { return this.dDistrField; }
        set { this.dDistrField = value; }
    }

    /// <remarks/>
    public string dProv
    {
        get { return this.dProvField; }
        set { this.dProvField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/09/xmldsig#"
)]
[System.Xml.Serialization.XmlRootAttribute(
    Namespace = "http://www.w3.org/2000/09/xmldsig#",
    IsNullable = true
)]
public partial class Signature
{
    private SignatureSignedInfo signedInfoField;

    private string signatureValueField;

    private SignatureKeyInfo keyInfoField;

    /// <remarks/>
    public SignatureSignedInfo SignedInfo
    {
        get { return this.signedInfoField; }
        set { this.signedInfoField = value; }
    }

    /// <remarks/>
    public string SignatureValue
    {
        get { return this.signatureValueField; }
        set { this.signatureValueField = value; }
    }

    /// <remarks/>
    public SignatureKeyInfo KeyInfo
    {
        get { return this.keyInfoField; }
        set { this.keyInfoField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/09/xmldsig#"
)]
public partial class SignatureSignedInfo
{
    private SignatureSignedInfoCanonicalizationMethod canonicalizationMethodField;

    private SignatureSignedInfoSignatureMethod signatureMethodField;

    private SignatureSignedInfoReference referenceField;

    /// <remarks/>
    public SignatureSignedInfoCanonicalizationMethod CanonicalizationMethod
    {
        get { return this.canonicalizationMethodField; }
        set { this.canonicalizationMethodField = value; }
    }

    /// <remarks/>
    public SignatureSignedInfoSignatureMethod SignatureMethod
    {
        get { return this.signatureMethodField; }
        set { this.signatureMethodField = value; }
    }

    /// <remarks/>
    public SignatureSignedInfoReference Reference
    {
        get { return this.referenceField; }
        set { this.referenceField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/09/xmldsig#"
)]
public partial class SignatureSignedInfoCanonicalizationMethod
{
    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get { return this.algorithmField; }
        set { this.algorithmField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/09/xmldsig#"
)]
public partial class SignatureSignedInfoSignatureMethod
{
    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get { return this.algorithmField; }
        set { this.algorithmField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/09/xmldsig#"
)]
public partial class SignatureSignedInfoReference
{
    private SignatureSignedInfoReferenceTransform[] transformsField;

    private SignatureSignedInfoReferenceDigestMethod digestMethodField;

    private string digestValueField;

    private string uRIField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Transform")]
    public SignatureSignedInfoReferenceTransform[] Transforms
    {
        get { return this.transformsField; }
        set { this.transformsField = value; }
    }

    /// <remarks/>
    public SignatureSignedInfoReferenceDigestMethod DigestMethod
    {
        get { return this.digestMethodField; }
        set { this.digestMethodField = value; }
    }

    /// <remarks/>
    public string DigestValue
    {
        get { return this.digestValueField; }
        set { this.digestValueField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string URI
    {
        get { return this.uRIField; }
        set { this.uRIField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/09/xmldsig#"
)]
public partial class SignatureSignedInfoReferenceTransform
{
    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get { return this.algorithmField; }
        set { this.algorithmField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/09/xmldsig#"
)]
public partial class SignatureSignedInfoReferenceDigestMethod
{
    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get { return this.algorithmField; }
        set { this.algorithmField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/09/xmldsig#"
)]
public partial class SignatureKeyInfo
{
    private SignatureKeyInfoX509Data x509DataField;

    /// <remarks/>
    public SignatureKeyInfoX509Data X509Data
    {
        get { return this.x509DataField; }
        set { this.x509DataField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/09/xmldsig#"
)]
public partial class SignatureKeyInfoX509Data
{
    private string x509SubjectNameField;

    private string x509CertificateField;

    /// <remarks/>
    public string X509SubjectName
    {
        get { return this.x509SubjectNameField; }
        set { this.x509SubjectNameField = value; }
    }

    /// <remarks/>
    public string X509Certificate
    {
        get { return this.x509CertificateField; }
        set { this.x509CertificateField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rFEGNoFirm
{
    private string dQRCodeField;

    /// <remarks/>
    public string dQRCode
    {
        get { return this.dQRCodeField; }
        set { this.dQRCodeField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa/wsdl/FeRecepFE"
)]
public partial class rRetConsDescFeXContenFERContFeXProtFe
{
    private rProtFe rProtFeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://dgi-fep.mef.gob.pa")]
    public rProtFe rProtFe
    {
        get { return this.rProtFeField; }
        set { this.rProtFeField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
[System.Xml.Serialization.XmlRootAttribute(
    Namespace = "http://dgi-fep.mef.gob.pa",
    IsNullable = true
)]
public partial class rProtFe
{
    private string dVerFormField;

    private rProtFeGInfProt gInfProtField;

    private Signature signatureField;

    /// <remarks/>
    public string dVerForm
    {
        get { return this.dVerFormField; }
        set { this.dVerFormField = value; }
    }

    /// <remarks/>
    public rProtFeGInfProt gInfProt
    {
        get { return this.gInfProtField; }
        set { this.gInfProtField = value; }
    }

    /// <remarks/>
    public Signature Signature
    {
        get { return this.signatureField; }
        set { this.signatureField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rProtFeGInfProt
{
    private string dIdField;

    private int iAmbField;

    private string dVerAplField;

    private string dCUFEField;

    private System.DateTime dFecProcField;

    private string dProAutField;

    private string dDigValField;

    private rProtFeGInfProtGResProc gResProcField;

    /// <remarks/>
    public string dId
    {
        get { return this.dIdField; }
        set { this.dIdField = value; }
    }

    /// <remarks/>
    public int iAmb
    {
        get { return this.iAmbField; }
        set { this.iAmbField = value; }
    }

    /// <remarks/>
    public string dVerApl
    {
        get { return this.dVerAplField; }
        set { this.dVerAplField = value; }
    }

    /// <remarks/>
    public string dCUFE
    {
        get { return this.dCUFEField; }
        set { this.dCUFEField = value; }
    }

    /// <remarks/>
    public System.DateTime dFecProc
    {
        get { return this.dFecProcField; }
        set { this.dFecProcField = value; }
    }

    /// <remarks/>
    public string dProAut
    {
        get { return this.dProAutField; }
        set { this.dProAutField = value; }
    }

    /// <remarks/>
    public string dDigVal
    {
        get { return this.dDigValField; }
        set { this.dDigValField = value; }
    }

    /// <remarks/>
    public rProtFeGInfProtGResProc gResProc
    {
        get { return this.gResProcField; }
        set { this.gResProcField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://dgi-fep.mef.gob.pa"
)]
public partial class rProtFeGInfProtGResProc
{
    private string dCodResField;

    private string dMsgResField;

    private string dCufeField;

    /// <remarks/>
    public string dCodRes
    {
        get { return this.dCodResField; }
        set { this.dCodResField = value; }
    }

    /// <remarks/>
    public string dMsgRes
    {
        get { return this.dMsgResField; }
        set { this.dMsgResField = value; }
    }

    /// <remarks/>
    public string dCufe
    {
        get { return this.dCufeField; }
        set { this.dCufeField = value; }
    }
}
