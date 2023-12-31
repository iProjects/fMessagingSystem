﻿SEMANTIC LOGGING APPLICATION BLOCK (SLAB)
OUT-OF-PROCESS SERVICE
http://slab.codeplex.com

Summary: The Semantic Logging Application Block provides a set of destinations (sinks) to persist application events published using a subclass of the EventSource class from the System.Diagnostics.Tracing namespace. Sinks include Azure table storage, SQL Server databases, Elasticsearch, and rolling files with several formats and you can extend the block by creating your own custom formatters and sinks. For the sinks that can store structured data, the block preserves the full structure of the event payload in order to facilitate analysing or processing the logged data.

This out-of-process Windows Service logs events using the Event Tracing for Windows (ETW) infrastructure that is part of the Windows operating system.

In order to install the required dependencies for the service, run the install-packages.ps1 script.

Updated release notes are available at http://slab.codeplex.com/wikipage?title=SLAB1.1ReleaseNotes

Microsoft patterns & practices
http://microsoft.com/practices
