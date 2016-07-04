{% macro field(fld) -%}
public {{ fld.type | csharp_type }} {{ fld.name | csharp_name }};
{%- endmacro %}


{% macro class_body(cls) %}
{
    {% for fld in cls.fields %}
    {{ field(fld) }}
    {% endfor -%}

    {% for innerClass in cls.classes %}
    {{ inner_class(innerClass) | indent(4, false) }}
    {%- endfor -%}
}
{%- endmacro %}


{% macro class(cls) %}
public partial class {{ cls.name | pascal }}
{{ class_body(cls) }}
{%- endmacro %}


{% macro inner_class(cls) %}

public class {{ cls.name | pascal }}
{{ class_body(cls) }}
{%- endmacro %}
