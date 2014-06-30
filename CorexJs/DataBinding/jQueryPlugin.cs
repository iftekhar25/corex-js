﻿using SharpKit.Html;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorexJs.DataBinding
{

    [JsType(JsMode.Prototype, Name = "$", PrototypeName = "fn", OmitDefaultConstructor = true, OmitInheritance = true, Filename = "~/res/databind.js")]
    class jQueryPlugin : jQuery
    {
        public jQuery databind() { return Plugin.databind(this); }

        public jQuery databindback() { return Plugin.databindback(this); }

        public jQuery dataparent()
        {
            var source = this.data("source");
            jQuery prev = this;
            jQuery el = this.parent();
            while (el.length>0)
            {
                if (el.data("source") != source)
                    break;
                prev = el;
                el = el.parent();
            }
            return prev;
        }
    }

    [JsType(JsMode.Prototype, Export = false)]
    static class jQueryDataBindingPluginExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery databind(this jQuery j) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery databindback(this jQuery j) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery dataparent(this jQuery j) { return null; }
    }


}