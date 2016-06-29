{% macro class(cls, indent) %}
indent = {{ indent }}
public partial class {{ cls.name | pascal_case }}
{
    {% for field in cls.fields %}
    public {{ field.type }} {{ field.name }};
    {% endfor %}

    {% for innerClass in cls.classes %}
    {{ class(innerClass, indent + 4) | indent(indent + 4, true) }}
    {% endfor %}
}
{% endmacro %}
