﻿//-----------------------------------------------------------------------
// <copyright file="HoconConfigurationElement.cs" company="Hocon Project">
//     Copyright (C) 2009-2015 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2015 Akka.NET project <https://github.com/akkadotnet/hocon>
// </copyright>
//-----------------------------------------------------------------------
#if !DNXCORE50
using System.Configuration;

namespace Akka.Configuration.Hocon
{
    /// <summary>
    /// This class represents a custom HOCON (Human-Optimized Config Object Notation)
    /// node within a configuration file.
    /// <code>
    /// <![CDATA[
    /// <?xml version="1.0" encoding="utf-8" ?>
    /// <configuration>
    ///   <configSections>
    ///     <section name="akka" type="AkkaConfiguration.Hocon.AkkaConfigurationSection, Akka" />
    ///   </configSections>
    ///   <akka>
    ///     <hocon>
    ///     ...
    ///     </hocon>
    ///   </akka>
    /// </configuration>
    /// ]]>
    /// </code>
    /// </summary>
    public class HoconConfigurationElement : CDataConfigurationElement
    {
        /// <summary>
        /// Gets or sets the HOCON configuration string contained in the hocon node.
        /// </summary>
        [ConfigurationProperty(ContentPropertyName, IsRequired = true, IsKey = true)]
        public string Content
        {
            get { return (string) base[ContentPropertyName]; }
            set { base[ContentPropertyName] = value; }
        }
    }
}
#endif
