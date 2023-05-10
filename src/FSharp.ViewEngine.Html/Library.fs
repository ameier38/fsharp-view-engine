﻿namespace FSharp.ViewEngine.Html

open FSharp.ViewEngine

type Html =
    static member fragment (children:Element seq) = Fragment children
    static member raw (v:string) = Raw v
    static member html (attrs:Attribute list) = Fragment [ Void ("!DOCTYPE", [ Boolean "html" ]); Tag ("html", attrs) ]
    static member head (children:Element list) = Tag ("head", [ Children children ])
    static member title (value:string) = Tag ("title", [ Children [ Raw value ] ])
    static member meta (attrs:Attribute seq) = Void ("meta", attrs)
    static member link (attrs:Attribute seq) = Void ("link", attrs)
    static member script (attrs:Attribute seq) = Tag ("script", attrs)
    static member body (attrs:Attribute seq) = Tag ("body", attrs)
    static member main (attrs:Attribute seq) = Tag ("main", attrs)
    static member header (attrs:Attribute seq) = Tag ("header", attrs)
    static member footer (attrs:Attribute seq) = Tag ("footer", attrs)
    static member nav (attrs:Attribute seq) = Tag ("nav", attrs)
    static member h1 (attrs:Attribute seq) = Tag ("h1", attrs)
    static member h2 (attrs:Attribute seq) = Tag ("h2", attrs)
    static member h3 (attrs:Attribute seq) = Tag ("h3", attrs)
    static member h4 (attrs:Attribute seq) = Tag ("h4", attrs)
    static member div (attrs:Attribute seq) = Tag ("div", attrs)
    static member p (attrs:Attribute seq) = Tag ("p", attrs)
    static member span (attrs:Attribute seq) = Tag ("span", attrs)
    static member a (attrs:Attribute seq) = Tag ("a", attrs)
    static member button (attrs:Attribute seq) = Tag ("button", attrs)
    static member img (attrs:Attribute seq) = Tag ("img", attrs)
    static member code (attrs:Attribute seq) = Tag ("code", attrs)
    static member pre (attrs:Attribute seq) = Tag ("pre", attrs)
    static member br = Void ("br", [])
    static member ul (attrs:Attribute seq) = Tag ("ul", attrs)
    static member ol (attrs:Attribute seq) = Tag ("ol", attrs)
    static member li (attrs:Attribute seq) = Tag ("li", attrs)
    static member blockquote (attrs:Attribute seq) = Tag ("blockquote", attrs)
    static member article (attrs:Attribute seq) = Tag("article", attrs)
    static member time (attrs:Attribute seq) = Tag("time", attrs)
    
    static member _id (v:string) = KeyValue ("id", v)
    static member _class (v:string) = KeyValue ("class", v)
    static member _class (v:string seq) = KeyValue ("class", v |> String.concat " ")
    static member _style (v:string) = KeyValue ("style", v)
    static member _children (v:Element seq) = Children v
    static member _children (v:Element) = Children [ v ]
    static member _children (v:string) = Children [ Raw v ]
    static member _lang (v:string) = KeyValue ("lang", v)
    static member _charset (v:string) = KeyValue ("charset", v)
    static member _name (v:string) = KeyValue ("name", v)
    static member _content (v:string) = KeyValue ("content", v)
    static member _href (v:string) = KeyValue ("href", v)
    static member _rel (v:string) = KeyValue ("rel", v)
    static member _src (v:string) = KeyValue ("src", v)
    static member _action (v:string) = KeyValue("action", v)
    static member _method (v:string) = KeyValue("method", v)
    static member _data (attr:string, ?v:string) = let key = $"data-{attr}" in match v with Some v -> KeyValue (key, v) | None -> Boolean(key)
    static member _datetime (v:string) = KeyValue("datetime", v)
    static member _width (v:string) = KeyValue("width", v)
    static member _height (v:string) = KeyValue("height", v)
