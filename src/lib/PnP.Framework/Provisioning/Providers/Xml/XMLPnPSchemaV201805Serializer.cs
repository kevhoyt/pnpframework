﻿namespace PnP.Framework.Provisioning.Providers.Xml
{
    /// <summary>
    /// Implements the logic to serialize a schema of version 201805
    /// </summary>
    internal class XMLPnPSchemaV201805Serializer : XmlPnPSchemaBaseSerializer<V201805.ProvisioningTemplate>
    {
        public XMLPnPSchemaV201805Serializer() :
            base(typeof(XMLConstants)
                .Assembly
                .GetManifestResourceStream("PnP.Framework.Provisioning.Providers.Xml.ProvisioningSchema-2018-05.xsd"))
        {
        }

#pragma warning disable CS0618
        public override string NamespaceUri => XMLConstants.PROVISIONING_SCHEMA_NAMESPACE_2018_05;
#pragma warning restore CS0618

        public override string NamespacePrefix => XMLConstants.PROVISIONING_SCHEMA_PREFIX;
        
        protected override void DeserializeTemplate(object persistenceTemplate, Model.ProvisioningTemplate template)
        {
            base.DeserializeTemplate(persistenceTemplate, template);
        }

        protected override void SerializeTemplate(Model.ProvisioningTemplate template, object persistenceTemplate)
        {
            base.SerializeTemplate(template, persistenceTemplate);
        }
    }
}

