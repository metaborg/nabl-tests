nabl-tests
==========

Language tests for name and type analysis using NaBL and the task engine. Each language has 3 folders:
* library: contains any language built-in libraries that are needed to analyze that language.
* examples: contains negative (failing) and positive (succeeding) examples.
* tests: contains Spoofax testing langauge files with name and type analysis tests.

Requires:
* spoofax-csharp: https://github.com/metaborg/spoofax-csharp
* webdsl2: https://github.com/webdsl/webdsl2
