# eXtendable Config Language
eXtendable Config Language or XCL is a language for writing config files,
originally created for [Mica For Everyone](https://github.com/MicaForEveryone/MicaForEveryone).

## Syntax
```
<Class Name>: <Constructor Parameters> {
    <Field Name> = <Field Value>
}
```

## Primitive types
* `bool`: boolean, possible values: `True`, `true`, `False`, `false`.

* `string`: characters string

* Enumeration types can be added to parser context during runtime.

## Classes
Classes can be added to parser context during runtime.
