# ActiveReports WebViewer behind reverse proxy

## Problem Description

In production we have the component behind an application gateway, but the same symptoms show using an IIS reverse proxy as configured in `reverseproxy_web.config`.

The WebViewer component will automatically try to fetch resources from WebResource.axd using the correct domain but ignoring the reverse proxy folder.


## Example Setup
1. Reverse proxy rewrites https://example.com/reportservice/ to https://reports.example.com/
1. User opens https://example.com/reportservice to view a report
1. WebViewer will attempt to download javascript block from https://example.com/WebResource.axd?q=...
    - The correct url would've been https://example.com/reportservice/WebResource.asd?q=...
1. WebViewer gets stuck on `Rendering...` as the necessary javascript has not been loaded


## What we need help with

Do you know any good ways to be able to override the folder it uses for WebResource.axd and ScriptResource.axd resources? If we could override the root path of the application or where it looks for these two endpoints it'd be trivial to solve our issue with a config option.