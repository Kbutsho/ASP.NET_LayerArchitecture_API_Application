import axios from 'axios';
import React, { useEffect, useState } from 'react';

axios.defaults.headers['Access-Control-Allow-Origin'] = '*'
axios.defaults.headers['Access-Control-Allow-Methods'] = 'PUT,GET,POST,DELETE,OPTIONS'
axios.defaults.allow_headers = "Referer,Accept,Origin,User-Agent,Content-Type"
axios.defaults.headers['Access-Control-Allow-Headers'] = axios.defaults.allow_headers
const App = () => {




  const [data, setData] = useState([]);
  //

  useEffect(()=>{
    axios.get(`https://localhost:44346/api/customerList`)
    .then(res=> setData(res.data))
    .catch(err=>{
      console.log(err);
    })
  },[])
  console.log(data);
  return (
    <div>
      hello
    </div>
  );
};

export default App;