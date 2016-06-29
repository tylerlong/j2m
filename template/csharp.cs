public partial class {{ class | pascal_case }}
{
  {% for field in fields %}
  public {{ field.type }} {{ field.name }};
  {% endfor %}
}
