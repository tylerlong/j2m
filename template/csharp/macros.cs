{% macro class_internal(cls) %}
{
    {% for field in cls.fields %}
    public {{ field.type }} {{ field.name }};
    {% endfor -%}

    {% for innerClass in cls.classes %}
    {{ inner_class(innerClass) | indent(4, false) }}
    {%- endfor -%}
}
{%- endmacro %}


{% macro class(cls) %}
public partial class {{ cls.name | pascal_case }}
{{ class_internal(cls) }}
{%- endmacro %}


{% macro inner_class(cls) %}

public class {{ cls.name | pascal_case }}
{{ class_internal(cls) }}
{%- endmacro %}
