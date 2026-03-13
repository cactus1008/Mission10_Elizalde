import { useEffect, useState } from 'react';
import type { bowler } from './types/bowler';

function BowlerList() {

    const [bowlers, setBowlers] = useState<bowler[]>([]);

    useEffect(() => {
        const fetchBowler = async () => {
            const response = await fetch('https://localhost:5050/BowlingInfo');
            const data = await response.json();
            setBowlers(data);
        }
        fetchBowler();
    }, [])
    
    return (
        <>
            <div className="table-container">
                <table>
                    <thead>
                        <tr>
                            <th>Bowler Name</th>
                            <th>Address</th>
                            <th>City</th>
                            <th>State</th>
                            <th>Zip Code</th>
                            <th>Phone Number</th>
                            <th>Team Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        {bowlers.map((f) => 
                        ( 
                            <tr key={f.bowlerId}>
                                <td>{f.bowlerFirstName} {f.bowlerMiddleInit} {f.bowlerLastName}</td>
                                <td>{f.bowlerAddress}</td>
                                <td>{f.bowlerCity}</td>
                                <td>{f.bowlerState}</td>
                                <td>{f.bowlerZip}</td>
                                <td>{f.bowlerPhoneNumber}</td>
                                <td>{f.team.teamName}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            </div>
        </>
    )
}

export default BowlerList;