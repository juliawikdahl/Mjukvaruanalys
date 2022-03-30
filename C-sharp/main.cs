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
ELSE 
OUTPUT "Vad synd name!"


