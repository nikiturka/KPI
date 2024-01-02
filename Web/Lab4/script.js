//1) Факультет
const faculty = {
  name: '',
  tel: ''
}

function inputData() {

  const facultyInput = document.getElementById('myInputFaculty').value
  const telInput = document.getElementById('myInputGroup').value

  document.getElementById('inputDatap').innerHTML = 'Res: назва: ' + facultyInput + ', телефон: ' + telInput

  faculty.name = facultyInput
  faculty.tel = telInput

  console.log(faculty.name + ' ' + faculty.tel)
}

//2) Група
const group = {
  spec: '',
  shirf: '',
  kolStud: ''
}

function inputDate() {

  const specInput = document.getElementById('myInputSpec').value
  const shirfInput = document.getElementById('myInputShirf').value
  const kolStudInput = document.getElementById('myInputKolStud').value

  document.getElementById('inputDatep').innerHTML = 'Res: спеціальність: ' + specInput + ', ширф: ' + shirfInput + ' та кількість студентів: ' + kolStudInput

  group.spec  = specInput
  group.shirf = shirfInput
  group.kolStud = kolStudInput

  console.log(group.spec + ' ' + group.shirf + ' ' + group.kolStud)
}

function addData() {

  const changeSpecInput = document.getElementById('myChangeInputSpec').value
  const changeShirfInput = document.getElementById('myChangeInputShirf').value
  const changeKolStudInput = document.getElementById('myChangeInputKolStud').value

  if (!group.spec) group.spec === group.spec
  else group.spec += changeSpecInput

  if (!group.shirf) group.shirf === group.shirf
  else group.shirf += changeShirfInput

  if (!group.kolStud) group.kolStud === group.kolStud
  else group.kolStud += changeKolStudInput

  document.getElementById('addDatap').innerHTML = 'Res: змінена спеціальність: ' + group.spec + ', змінений ширф: ' + group.shirf + ' та змінена кількість студентів: ' + group.kolStud

  console.log('Added: ', group.spec + ' ' + group.shirf + ' ' + group.kolStud)

}

function updateData() {

  const updateSpecInput = document.getElementById('myUpdateInputSpec').value
  const updateShirfInput = document.getElementById('myUpdateInputShirf').value
  const updateKolStudInput = document.getElementById('myUpdateInputKolStud').value

  if (!group.spec) group.spec === group.spec
  else group.spec = updateSpecInput

  if (!group.shirf) group.shirf === group.shirf
  else group.shirf = updateShirfInput

  if (!group.kolStud) group.kolStud === group.kolStud
  else group.kolStud = updateKolStudInput

  document.getElementById('updateDatap').innerHTML = 'Res: замінена спеціальність: ' + group.spec + ', замінений ширф: ' + group.shirf + ' та змінена кількість студентів: ' + group.kolStud

  console.log('Updated: ', group.spec + ' ' + group.shirf + ' ' + group.kolStud)

}

function deleteData() {

  group.spec = "інформація успішно видалена"
  group.shirf = "інформація успішно видалена"
  group.kolStud = "інформація успішно видалена"

  document.getElementById('deleteDatap').innerHTML = 'Res: спеціальність: ' + group.spec + ', ширф: ' + group.shirf + ' кількість студентів: ' + group.kolStud

  console.log('Data deleted', group.spec + ' ' + group.shirf + ' ' + group.kolStud)
}

//3)Копіювання властивостей і методів в 'copy'
function copyData() {

  const copy = {
    facultyName: faculty.name,
    facultyTel: faculty.tel,
    groupSpec: group.spec,
    groupShirf: group.shirf,
    groupKolStud: group.kolStud
  }

  document.getElementById('copyDatap').innerHTML = 'Назва факультету: ' + copy.facultyName + ', телефон: ' + copy.facultyTel + ', спеціальність групи: ' + copy.groupSpec + ', ширф: ' + copy.groupShirf + ', кількість студентів: ' + copy.groupKolStud

  console.log('Copy data', copy.facultyName + ' ' + copy.facultyTel + ' ' + copy.groupSpec + ' ' + copy.groupShirf + ' ' + copy.groupKolStud)

}

//Притаился 4 пункт
Object.prototype.showData = function () {

  document.getElementById('showDatap').innerHTML = 'Res: спеціальність: ' + group.spec + ', ширф: ' + group.shirf + ' кількість студентів: ' + group.kolStud

  console.log('Show data', group.spec + ' ' + group.shirf + ' ' + group.kolStud)

}

// 5)
function neVidrahovani() {

  const sesia = {
    sesiaSpec: group.spec,
    sesiaShirf: group.shirf,
    sesiaKolStud: group.kolStud,
    sesiaVidrahovano: 0
  }

    sesia.sesiaVidrahovano = document.getElementById('myVidrahovano').value

    console.log(group.kolStud);
    console.log(typeof(group.kolStud));
    console.log(sesia.sesiaVidrahovano);
    console.log(typeof(sesia.sesiaVidrahovano));


  if (Number(sesia.sesiaVidrahovano) > Number(group.kolStud)) return alert('Помилка: кількість відрахованих студентів не може бути більша за кількість всіх студентів')
  else {

    const vidsotokNeVidrahovanih = ((sesia.sesiaKolStud - sesia.sesiaVidrahovano) / sesia.sesiaKolStud) * 100

    document.getElementById('neVidrahovanip').innerHTML = 'Кількість студентів в групі: ' + sesia.sesiaKolStud + ', кількість відрахованих: ' + sesia.sesiaVidrahovano + ', Відсоток не відрахованих студентів: ' + vidsotokNeVidrahovanih + '%'

    console.log('Кількість студентів в групі: ' + sesia.sesiaKolStud + ', кількість відрахованих: ' + sesia.sesiaVidrahovano + ', Відсоток не відрахованих студентів: ' + vidsotokNeVidrahovanih + '%')

  }
}

// 6)
class Group {
  constructor(options) {
    this._stydent = options.stydent
    this._stydentka = options.stydentka
    this._facultet = options.facultet
  }

  get stydent() {
    return this._stydent
  }

  set stydent(value) {
    this._stydent = value
  }

  get stydentka() {
    return this._stydentka
  }

  set stydentka(value) {
    this._stydentka = value
  }

  get facultet() {
    return this._facultet
  }

  set facultet(value) {
    this._facultet = value
  }
}

class Session extends Group {
  constructor(options) {
    super(options)
    this.updateAllStudent()
  }

  get allStudent() {
    return this._allStudent
  }

  updateAllStudent() {
    this._allStudent = this.stydent + this.stydentka
  }
}

// Пример использования:
const options = {
  stydent: 0,
  stydentka: 0,
  facultet: '',
}

const session = new Session(options)

function allStuds() {
  const inputStydent = parseInt(document.getElementById('myInputStydent').value, 10)
  const inpuntStudentka = parseInt(document.getElementById('myInpuntStudentka').value, 10)
  const inputFacultet = document.getElementById('myInputFacultet').value

  const group = new Group({
    stydent: inputStydent,
    stydentka: inpuntStudentka,
    facultet: inputFacultet,
  })

  const sessionGroup = new Session({
    stydent: inputStydent,
    stydentka: inpuntStudentka,
    facultet: inputFacultet,
  })

  document.getElementById('allStudsp').innerHTML = 'Res: кількість хлопців: ' + group.stydent + ', кількість дівчат: ' + group.stydentka + ', кількість всіх студентів: ' + sessionGroup.allStudent + ' та факультет: ' + group.facultet

  console.log(session.allStudent)

}