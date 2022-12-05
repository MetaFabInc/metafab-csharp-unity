# Metafab SDK For Unity

## Installation (Package Manager via git url)

Add this line to `Packages/manifest.json`:

```
"com.metafab.sdk": "https://github.com/MetaFabInc/metafab-unity.git"
```

This package requires UniTask 2.3.3 for an allocation-free `async/await` wrapper on `UnityWebRequest`

Install via [openupm](https://openupm.com/docs/getting-started.html):

```
openupm add com.cysharp.unitask
```

### Logging

Log levels in editor are controlled by config.

In builds all logging is disabled unless `METAFAB_LOGGING` is defined in Unity's `Scripting Define Symbols`

### Todo

* graceful fallback to coroutines if user doesn't have UniTask
* create .unitypackage in releases
* integrate with openupm