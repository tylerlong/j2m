{% macro class(cls) %}

public partial class {{ cls.name | pascal_case }}
{
    {% for field in cls.fields %}
    public {{ field.type }} {{ field.name }};
    {% endfor -%}

    {% for innerClass in cls.classes %}
    {{ class(innerClass) | indent(4, false) }}
    {%- endfor -%}
}
{%- endmacro %}
