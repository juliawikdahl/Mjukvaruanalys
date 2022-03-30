OUTPUT "Vad heter du?"
INPUT name

OUTPUT "hur gammal är du"
INPUT age

OUTPUT "har du ett husdjur?"
INPUT anmial

if animal equals "ja" 
    OUTPUT "hur gammal är den?"
    INPUT animal_age

    SET different_age = age - animal_age
    OUTPUT "vad heter den?"
    INPUT animal_name

    OUTPUT "name du var alltså different_age år gammal när ditt husdjur animal_name föddes."

else if animal equals "nej"
OUTPUT "Vad tråkigt, gillar du djur?"
INPUT want_one
  if want_one equals "ja"
  OUTPUT "Om du måste välja, vad väljer du? katt/hund?"
  INPUT cat_dog
     if cat_dog equals "hund"
     OUTPUT "bra val, jag har en golden retriver"
     else if cat_dog equals "katt"
     OUTPUT "Super bra val! Katter är mitt favoritdjur, har tre stycken själv."
  else if want_one equals "nej"
  OUTPUT "Vad tråkigt name"