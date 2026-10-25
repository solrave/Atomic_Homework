#!/usr/bin/env bash
# PreToolUse hook: запрещает менять файлы в Assets/Plugins (сторонние библиотеки).
# Читает JSON вызова инструмента из stdin. Exit 2 = заблокировать, stderr уходит Claude.

input=$(cat)
bs='\'

# Достаём строковое поле JSON и приводим слеши к "/" (на Windows они приходят как \\).
field() {
  printf '%s' "$input" \
    | grep -oE "\"$1\" *: *\"([^\"$bs$bs]|[$bs$bs].)*\"" \
    | sed -E 's/^"[^"]*" *: *"//; s/"$//' \
    | tr -s '\\' '/'
}

in_plugins='(^|/)Assets/Plugins(/|$)'

# Edit / Write / NotebookEdit: проверяем путь к файлу.
if field file_path | grep -Eiq "$in_plugins" || field notebook_path | grep -Eiq "$in_plugins"; then
  echo "Заблокировано: Assets/Plugins — сторонние библиотеки, их нельзя менять (см. CLAUDE.md)." >&2
  exit 2
fi

# Bash: блокируем команды, которые упоминают Assets/Plugins вместе с изменяющими операциями.
cmd=$(field command)
if printf '%s' "$cmd" | grep -Eiq 'Assets/Plugins'; then
  if printf '%s' "$cmd" | grep -Eiq '(^|[^a-z])(rm|mv|cp|touch|mkdir|rmdir|tee|dd|truncate|chmod|patch|del|rd|ren|move|copy)([^a-z]|$)|sed +(-[a-z]*i)|>|git +(checkout|restore|clean|reset|apply|rm|mv)|Set-Content|Out-File|Remove-Item|Move-Item|Copy-Item|New-Item'; then
    echo "Заблокировано: команда меняет Assets/Plugins — сторонние библиотеки, их нельзя менять." >&2
    exit 2
  fi
fi

exit 0
