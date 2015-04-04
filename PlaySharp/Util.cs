﻿using System.Text.RegularExpressions;
using System.Xml;

namespace PlaySharp
{
    public static class Util
    {
        /// <summary>
        ///     Gets the attribute value of a node as a string or returns DefaultValue if it doesn't exist.
        /// </summary>
        public static string GetNodeAttributeValue(XmlNode node, string attributeName, string defaultValue = "")
        {
            if (node == null)
                return defaultValue;
            if (node.Attributes == null)
                return defaultValue;
            var attr = node.Attributes[attributeName];
            return attr != null ? attr.Value : defaultValue;
        }

        /// <summary>
        ///     Gets the InnerText of a node as a string or returns DefaultValue if it doesn't exist.
        /// </summary>
        public static string GetNodeInnerText(XmlNode node, string defaultValue = "")
        {
            return node != null ? node.InnerText : defaultValue;
        }

        /// <summary>
        ///     Gets the attribute value of the first child node of ParentNode that matches the XPath expression ChildNodePath as a
        ///     string or returns DefaultValue if it doesn't exist.
        /// </summary>
        public static string GetChildNodeAttributeValue(XmlNode parentNode, string childNodePath, string attributeName, string defaultValue = "")
        {
            return parentNode != null ? GetNodeAttributeValue(parentNode.SelectSingleNode(childNodePath), attributeName, defaultValue) : defaultValue;
        }

        /// <summary>
        ///     Returns true if the string Value matches the string Pattern using * to match multiple characters and ? to match a
        ///     single character.
        /// </summary>
        public static bool MatchesPattern(string value, string pattern)
        {
            return new Regex("(?i)^" + Regex.Escape(pattern).Replace(@"\*", ".*").Replace(@"\?", ".") + "$").IsMatch(value);
        }
    }
}