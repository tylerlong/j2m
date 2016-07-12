{% macro field(fld, cls) -%}
public {% if fld.type == cls.name %}_{% endif %}{{ fld.type | csharp_type }} {{ fld.name | csharp_name }};
{%- endmacro %}


{% macro class_body(cls) %}
{
    {% for fld in cls.fields %}
    {{ field(fld, cls) }}
    {% endfor -%}

    {% for innerClass in cls.classes %}
    {{ inner_class(innerClass, cls) | indent(4, false) }}
    {%- endfor -%}
}
{%- endmacro %}


{% macro class(cls) %}
public partial class {{ cls.name }}
{{ class_body(cls) }}
{%- endmacro %}


{% macro inner_class(innerClass, cls) %}

public class {% if innerClass.name == cls.name %}_{% endif %}{{ innerClass.name }}
{{ class_body(innerClass) }}
{%- endmacro %}
