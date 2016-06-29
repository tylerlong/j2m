public partial class {{ class | title }}
{
  {% for field in fields %}
  public {{ field.type }} {{ field.name }};
  {% endfor %}
}
